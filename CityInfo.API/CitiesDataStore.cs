﻿using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDTO> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDTO>()
            {
                new CityDTO()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterestDTO>()
                    {
                        new PointOfInterestDTO()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States."
                        },
                        new PointOfInterestDTO()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan."
                        }
                    }
                },
                new CityDTO()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished.",
                    PointsOfInterest = new List<PointOfInterestDTO>()
                    {
                        new PointOfInterestDTO()
                        {
                            Id = 3,
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States."
                        },
                        new PointOfInterestDTO()
                        {
                            Id = 4,
                            Name = "Antwerp Central Station",
                            Description = "The finest example of railway architecture in Belgium."
                        }
                    }
                },
                new CityDTO()
                {
                    Id =3,
                    Name = "Paris",
                    Description = "The one with that big tower.",
                    PointsOfInterest = new List<PointOfInterestDTO>()
                    {
                        new PointOfInterestDTO()
                        {
                            Id = 5,
                            Name = "Eiffel Tower",
                            Description = "A wrought iron lattice tower on the Champs de Mars, named after it's creator."
                        },
                        new PointOfInterestDTO()
                        {
                            Id = 6,
                            Name = "The Louvre",
                            Description = "The world's largest museum."
                        }
                    }
                }
            };
        }
    }
}
