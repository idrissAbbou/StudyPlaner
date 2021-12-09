namespace StudyPlan.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudyPlan.StudyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StudyPlan.StudyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            List<Subject> subjects = new List<Subject>();
            subjects.Add(new Subject() { Item = "math", Category = "bac libre", TotalHours = 0 });
            subjects.Add(new Subject() { Item = "pysics", Category = "bac libre", TotalHours = 0 });
            subjects.Add(new Subject() { Item = "C#", Category = "Programing", TotalHours = 0 });
            context.subjects.AddRange(subjects);
        }
    }
}
