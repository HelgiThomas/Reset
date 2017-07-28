using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inspinia_MVC5_SeedProject.Models
{
    public enum Sex
    {
        Male, Female
    }
    public class Athlete
    {
        //Represents the Id of each athlete, database generated
        public int AthleteID { get; set; }

        //Represents the Name of the athlete (both first, middle and last)
        public string Name { get; set; }

        // Represents the sex of the athlete, either Male or Female
        public string Sex { get; set; }

        // Represents the SocialSecurity number (kennitala) of the athlete
        public string SocialSecurity { get; set; }

        // Represents the Sport the athlete plays, not required
        public string Sport { get; set; }

        // Represents the team that the athlete plays for, not required
        public string Team { get; set; }

        // Represents the enrollment of the athlete in the various measurements
        // The relationship is a one-to-many between Student and Enrollment
        // Enrollments is a navigation property
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}