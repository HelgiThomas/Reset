using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inspinia_MVC5_SeedProject.Models;

namespace Inspinia_MVC5_SeedProject.DAL
{
    public class ResetInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<ResetContext>
    {
        protected override void Seed(ResetContext context)
        {
            var athletes = new List<Athlete>
            {
                new Athlete{Name="Aðalgeir Friðriksson", Sex = Sex.Male, SocialSecurity="1601002060", Team="Fjölnir", Sport="Handbolti"},
                new Athlete{Name="Alexander Batt Þorleifsson", Sex = Sex.Male, SocialSecurity="2810002330", Team="Fjölnir", Sport="Handbolti"},
                new Athlete{Name="Alexander Máni Patriksson", Sex = Sex.Male, SocialSecurity="1406002450", Team="Fjölnir", Sport="Fótbolti"},
                new Athlete{Name="Alísa Rakel Abrahamsdóttir", Sex = Sex.Female, SocialSecurity="1008992489", Team="Fjölnir", Sport="Tennis"},
                new Athlete{Name="Andrea Jacobsen", Sex = Sex.Female, SocialSecurity="0904982319", Team="KR", Sport="Handbolti"},
                new Athlete{Name="Anton Benedikt Kröyer Antonsson", Sex = Sex.Male, SocialSecurity="2403002220", Team="KR", Sport="Handbolti"},
                new Athlete{Name="Arnar Geir Líndal", Sex = Sex.Male, SocialSecurity="2101002610", Team="KR", Sport="Fótbolti"},
                new Athlete{Name="Arnar Máni Rúnarsson", Sex = Sex.Male, SocialSecurity="3101002420", Team="KR", Sport="Tennis"},
                new Athlete{Name="Arnar Þór Þorvaldsson", Sex = Sex.Male, SocialSecurity="3003982869", Team="ÍR", Sport="Handbolti"},
                new Athlete{Name="Ástríður Glódís G Gísladóttir", Sex = Sex.Female, SocialSecurity="1601002060", Team="ÍR", Sport="Handbolti"},
                new Athlete{Name="Bryndís Bolladóttir", Sex = Sex.Female, SocialSecurity="0702993059", Team="ÍR", Sport="Fótbolti"},
                new Athlete{Name="Dóra Valgerður Óskarsdóttir", Sex = Sex.Female, SocialSecurity="2307003110", Team="ÍR", Sport="Tennis"}
            };

            athletes.ForEach(a => context.Athletes.Add(a));
            context.SaveChanges();

            var measurements = new List<Measurement>
            {
                new Measurement{Title="Weight", Desc="Measures the weight of the athlete", Unit = Unit.kg},
                new Measurement{Title="Height", Desc="Measures the height of the athlete", Unit = Unit.cm},
                new Measurement{Title="IAT", Desc="Measures the IAT", Unit = Unit.sec},
                new Measurement{Title="OHS", Desc="Measures the Over head squad of an athlete on a scale of 1-3", Unit = Unit.grade},
                new Measurement{Title="Davies T", Desc="Measures the Davies T, unit is number of repetitions", Unit = Unit.nr},
                new Measurement{Title="Vjump", Desc="Measures the vertical jump of the athlete", Unit = Unit.cm},
                new Measurement{Title="Ljump", Desc="Measures the longitude jump of the athlete", Unit = Unit.cm}
            };

            measurements.ForEach(m => context.Measurements.Add(m));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment{AthleteID=1, MeasurementID=1,Result=62.7, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=1, MeasurementID=2,Result=177.5, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=1, MeasurementID=3,Result=16.33, Grade=7, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=1, MeasurementID=4,Result=2, Grade=7, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=1, MeasurementID=5,Result=109, Grade=7, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=1, MeasurementID=6,Result=51, Grade=7, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=1, MeasurementID=7,Result=216, Grade=6, EnrollmentDate=DateTime.Parse("2017-07-28")},

                new Enrollment{AthleteID=2, MeasurementID=1, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=2, MeasurementID=2, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=2, MeasurementID=3, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=2, MeasurementID=4, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=2, MeasurementID=5, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=2, MeasurementID=6, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=2, MeasurementID=7, EnrollmentDate=DateTime.Parse("2017-07-28")},

                new Enrollment{AthleteID=3, MeasurementID=1,Result=82, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=3, MeasurementID=2,Result=190, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=3, MeasurementID=3,EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=3, MeasurementID=4,Result=2, Grade=7, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=3, MeasurementID=5,Result=70, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=3, MeasurementID=6,Result=42, Grade=4, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=3, MeasurementID=7,Result=197, Grade=4, EnrollmentDate=DateTime.Parse("2017-07-28")},

                new Enrollment{AthleteID=4, MeasurementID=1,Result=61.6, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=4, MeasurementID=2,Result=157, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=4, MeasurementID=3,Result=20.16, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=4, MeasurementID=4,Result=2, Grade=7, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=4, MeasurementID=5,Result=66, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=4, MeasurementID=6,Result=40, Grade=8, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=4, MeasurementID=7,Result=175, Grade=5, EnrollmentDate=DateTime.Parse("2017-07-28")},

                new Enrollment{AthleteID=5, MeasurementID=1,Result=73.3, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=5, MeasurementID=2,Result=181, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=5, MeasurementID=3,Result=16.43, Grade=10, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=5, MeasurementID=4,Result=3, Grade=10, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=5, MeasurementID=5,Result=101, Grade=7, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=5, MeasurementID=6,Result=44, Grade=9, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=5, MeasurementID=7,Result=220, Grade=10, EnrollmentDate=DateTime.Parse("2017-07-28")},

                new Enrollment{AthleteID=6, MeasurementID=1,Result=82.8, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=6, MeasurementID=2,Result=180.5, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=6, MeasurementID=3,Result=17.4, Grade=4, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=6, MeasurementID=4,Result=2, Grade=7, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=6, MeasurementID=5,Result=106, Grade=6, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=6, MeasurementID=6,Result=50, Grade=6, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=6, MeasurementID=7,Result=210, Grade=6, EnrollmentDate=DateTime.Parse("2017-07-28")},

                new Enrollment{AthleteID=7, MeasurementID=1,Result=83.6, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=7, MeasurementID=2,Result=184, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=7, MeasurementID=3,Result=17.01, Grade=5, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=7, MeasurementID=4,Result=2, Grade=7, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=7, MeasurementID=5,Result=104, Grade=6, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=7, MeasurementID=6,Result=53, Grade=7, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=7, MeasurementID=7,Result=202, Grade=5, EnrollmentDate=DateTime.Parse("2017-07-28")},

                new Enrollment{AthleteID=8, MeasurementID=1,Result=83.7, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=8, MeasurementID=2,Result=187, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=8, MeasurementID=3,Result=15.93, Grade=8, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=8, MeasurementID=4,Result=3, Grade=10, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=8, MeasurementID=5,Result=98, Grade=4, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=8, MeasurementID=6,Result=56, Grade=8, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=8, MeasurementID=7,Result=251, Grade=10, EnrollmentDate=DateTime.Parse("2017-07-28")},

                new Enrollment{AthleteID=9, MeasurementID=1,Result=62.6, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=9, MeasurementID=2,Result=177.5, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=9, MeasurementID=3,Result=17.03, Grade=5, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=9, MeasurementID=4,Result=2, Grade=7, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=9, MeasurementID=5,Result=105, Grade=6, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=9, MeasurementID=6,Result=45, Grade=5, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=9, MeasurementID=7,Result=200, Grade=5, EnrollmentDate=DateTime.Parse("2017-07-28")},

                new Enrollment{AthleteID=10, MeasurementID=1,Result=72.8, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=10, MeasurementID=2,Result=176.5, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=10, MeasurementID=3, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=10, MeasurementID=4,Result=3, Grade=10, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=10, MeasurementID=5,Result=94, Grade=6, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=10, MeasurementID=6,Result=39, Grade=8, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=10, MeasurementID=7,Result=169, Grade=4, EnrollmentDate=DateTime.Parse("2017-07-28")},

                new Enrollment{AthleteID=11, MeasurementID=1,Result=59.9, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=11, MeasurementID=2,Result=164.5, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=11, MeasurementID=3,Result=16.91, Grade=8, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=11, MeasurementID=4,Result=3, Grade=10, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=11, MeasurementID=5,Result=126, Grade=10, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=11, MeasurementID=6,Result=48, Grade=10, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=11, MeasurementID=7,Result=208, Grade=8, EnrollmentDate=DateTime.Parse("2017-07-28")},

                new Enrollment{AthleteID=12, MeasurementID=1,Result=65, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=12, MeasurementID=2,Result=162, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=12, MeasurementID=3,Result=20.35, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=12, MeasurementID=4,Result=2, Grade=7, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=12, MeasurementID=5,Result=91, Grade=5, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=12, MeasurementID=6,Result=33, Grade=6, EnrollmentDate=DateTime.Parse("2017-07-28")},
                new Enrollment{AthleteID=12, MeasurementID=7,Result=173, Grade=5, EnrollmentDate=DateTime.Parse("2017-07-28")}
            };

            enrollments.ForEach(e => context.Enrollments.Add(e));
            context.SaveChanges();
        }
    }
}