using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetTopologySuite.Geometries;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Graduation_Project.Models;
using NetTopologySuite.IO;
using System.IO;
using System.Linq;
using System;

namespace Graduation_Project.Controllers
{
   
        [ApiController]
        [Route("api/[controller]")]
        public class BuildingsRiskController : ControllerBase
        {
            private readonly Final_ProjectContext _dbContext;

          
            public BuildingsRiskController(Final_ProjectContext dbContext)
            {
                _dbContext = dbContext;
            }

            [HttpGet]
            public async Task<IActionResult> GetBuildingsRisk([FromQuery] int year, [FromQuery] double lrr, [FromQuery] double nsm, [FromQuery] double slope, [FromQuery] double elevation)
            {
            // 1️⃣ Build path to shoreline GeoJSON
            // 1️⃣ Call Python Flask API
            using var client = new HttpClient();

            // 👇 Replace with your actual Flask server URL
            string flaskUrl = "http://localhost:5000/predict";

            var payload = new
            {
                Year = year,
                LRR = lrr,
                NSM = nsm,
                Slope = slope,
                Elevation = elevation
            };

            // Send POST request
            var response = await client.PostAsJsonAsync(flaskUrl, payload);

            if (!response.IsSuccessStatusCode)
            {
                return BadRequest($"Python model returned error: {response.StatusCode}");
            }

            // Get predicted shoreline GeoJSON as string
            string geoJson = await response.Content.ReadAsStringAsync();
            var reader = new GeoJsonReader();
            Geometry shoreline;

            try
            {
                shoreline = reader.Read<Geometry>(geoJson);
                if (shoreline == null)
                {
                    return BadRequest("Invalid shoreline geometry returned from Python.");
                }
            }
            catch
            {
                return BadRequest("Failed to parse GeoJSON from Python API.");
            }


            // 3️⃣ Create buffers: High (0-50m), Medium (50-150m), Low (150-300m)
            var highBuffer = shoreline.Buffer(50);
                var medBuffer = shoreline.Buffer(150).Difference(highBuffer);
                var lowBuffer = shoreline.Buffer(300).Difference(medBuffer.Union(highBuffer));

                // 4️⃣ Load all buildings
                var buildings = _dbContext.BUILDINGs.ToList();

                // 5️⃣ For each building, check risk level
                var result = buildings.Select(b =>
                {
                    string risk = "None";

                    if (highBuffer.Intersects(b.Shape))
                    {
                        risk = "High";
                    }
                    else if (medBuffer.Intersects(b.Shape))
                    {
                        risk = "Medium";
                    }
                    else if (lowBuffer.Intersects(b.Shape))
                    {
                        risk = "Low";
                    }

                    return new
                    {
                        id = b.OBJECTID,
                        riskLevel = risk,
                        geometry = b.Shape.AsText() // Or convert to GeoJSON if you want
                    };
                });

                // 6️⃣ Return risk-tagged buildings to frontend
                return Ok(result);
            }
        }

    
}
