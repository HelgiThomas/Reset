using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inspinia_MVC5_SeedProject.Models
{
    public class Enrollment
    {
        // Represents the ID of the given enrollment between the athlete and the measurement, 
        // database generated
        public int EnrollmentID { get; set; }

        // Represents the ID of the athlete in the given enrollment
        public int AthleteID { get; set; }

        // Represents the ID of the measurement in the given enrollment
        public int MeasurementID { get; set; }

        // The actual athlete
        public virtual Athlete Athlete { get; set; }

        // The actual measurement
        public virtual Measurement Measurement { get; set; }

        // The date that the enrollment was taken
        public DateTime EnrollmentDate { get; set; }

        // Represents the result of the measurement for the given athlete
        public double? Result { get; set; }

        public int? Grade { get; set; }
    }
}