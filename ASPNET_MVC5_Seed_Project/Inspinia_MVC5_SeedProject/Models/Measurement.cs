using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inspinia_MVC5_SeedProject.Models
{
    public enum Unit
    {
        kg, cm, m, sec, nr, grade
    }

    public class Measurement
    {
        // Represents the ID of the given Measurement, database generated
        public int MeasurementID { get; set; }

        // Represents the title of the measurement
        public string Title { get; set; }

        // Represents the description of the measurement
        public string Desc { get; set; }

        // Represents the unit that the measurement is in
        // kg-> kilograms, cm-> centimeters, m-> meters, sec-> seconds
        // nr-> number, grade-> grade on a certain scale
        public Unit Unit { get; set; }
    }
}