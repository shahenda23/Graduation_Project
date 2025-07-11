using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations.Schema;

namespace Graduation_Project.Models
{
    public class UserLocation
    {
        public int Id { get; set; }
        public Geometry shape { get; set; }

        [ForeignKey("Account")]
        public int? Account_Id { get; set; }

        public Account? Account{ get; set; }

    }
}
