//using Microsoft.AspNetCore.Mvc;
//using NetTopologySuite.Geometries;
//using NetTopologySuite.IO;
//using NetTopologySuite.Features;
//using NetTopologySuite.Operation.Buffer;
//using NetTopologySuite.Geometries.Prepared;
//using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Graduation_Project.Models.DTO;


using Microsoft.AspNetCore.Mvc;

namespace Graduation_Project.Controllers
{
    [ApiController]
    [Route("api/BuildingsRisk")]
    public class BuildingsRiskController : ControllerBase
    {
        private readonly IConfiguration _config;
        public BuildingsRiskController(IConfiguration config)
        {
            _config = config;
        }
        [HttpGet("assess/{year}")]
        public async Task<IActionResult> AssessBuildingsRisk(int year)
        {
            using var client = new HttpClient();
            var pythonServiceUrl = _config.GetValue<string>("PythonServiceUrl", "\"http://localhost:5001\"");
            try
            {
                var response = await client.GetAsync($"{pythonServiceUrl}/assess_risk/{year}");
                if (!response.IsSuccessStatusCode)
                    return NotFound($"Risk assessment for {year} failed.");

                var content = await response.Content.ReadAsStringAsync();
                return Content(content, "application/json");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error contacting Python service: {ex.Message}");
            }
        }
        //        /// <summary>
        //        /// POST /api/BuildingsRisk/assess
        //        /// body: { year: 2043, bufferDistance: 50 }
        //        /// </summary>
        //        [HttpPost("assess")]
        //        public async Task<IActionResult> AssessRisk([FromBody] RiskRequestDto request)
        //        {
        //            // === 1️⃣ Load predicted shoreline GeoJSON ===
        //            string predictedPath = Path.Combine("Predicted", $"predicted_shoreline_{request.Year}.geojson");
        //            if (!System.IO.File.Exists(predictedPath))
        //                return NotFound($"Predicted shoreline for year {request.Year} not found.");

        //            var reader = new GeoJsonReader();
        //            FeatureCollection shorelineFeatures;
        //            using (var sr = new StreamReader(predictedPath))
        //            {
        //                shorelineFeatures = reader.Read<FeatureCollection>(sr.ReadToEnd());
        //            }

        //            // === 2️⃣ Buffer each point ===
        //            var bufferedGeometries = shorelineFeatures
        //                .Select(f => f.Geometry)
        //                .Select(g => g.Buffer(request.BufferDistance))
        //                .ToList();

        //            var bufferUnion = bufferedGeometries[0];
        //            for (int i = 1; i < bufferedGeometries.Count; i++)
        //            {
        //                bufferUnion = bufferUnion.Union(bufferedGeometries[i]);
        //            }

        //            // === 3️⃣ Load buildings layer (GeoJSON or DB) ===
        //            string buildingsPath = Path.Combine("Data", "buildings.geojson");
        //            if (!System.IO.File.Exists(buildingsPath))
        //                return NotFound("Buildings data not found.");

        //            FeatureCollection buildingFeatures;
        //            using (var sr = new StreamReader(buildingsPath))
        //            {
        //                buildingFeatures = reader.Read<FeatureCollection>(sr.ReadToEnd());
        //            }

        //            // === 4️⃣ Intersect buildings with buffer ===
        //            var riskyBuildings = new FeatureCollection();
        //            foreach (var building in buildingFeatures)
        //            {
        //                if (bufferUnion.Intersects(building.Geometry))
        //                {
        //                    riskyBuildings.Add(building);
        //                }
        //            }

        //            // === 5️⃣ Return intersected buildings as GeoJSON ===
        //            var writer = new GeoJsonWriter();
        //            string geoJsonResult = writer.Write(riskyBuildings);
        //            return Content(geoJsonResult, "application/json");
        //        }
    }
}

