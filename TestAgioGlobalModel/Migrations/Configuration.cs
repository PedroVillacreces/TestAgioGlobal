namespace TestAgioGlobalModel.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Collections.Generic;
    using Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<ModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ModelContext context)
        {
            var airport = new List<Airports>
            {
                new Airports() {AirtportName = "Madrid Barajas", Latitude = 40.4918100, Longitude = -3.5694800},
                new Airports() {AirtportName = "Malaga", Latitude = 36.669, Longitude = -4.4823},
                new Airports() {AirtportName = "Barcelona", Latitude = 41.289182, Longitude = 2.0746423},
                new Airports() {AirtportName = "Bilbao", Latitude = 43.3025, Longitude = -2.9111},
                new Airports() {AirtportName = "Sevilla", Latitude = 37.4180000, Longitude = -37.4180000}
            };

            context.Airports.AddRange(airport);
            base.Seed(context);
        }
    }
}
