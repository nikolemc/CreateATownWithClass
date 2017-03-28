using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateATownWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var BeachHouse = new House("BeachHouse")
            {
                BuildingType = "House",
                NumberofRoom = 12,
                ConstructionMaterial = "Wood",
                Height = 34,
                Width = 30,
                Length = 56,
                Floors = 2,
                Bedrooms = 4,
                Bathrooms = 3,
                Address1 = "250 Sunny Beach Drive",
                Address2 = "Unit B",
                City = "Madeira Beach",
                State = "Florida",
                Zip = "33504",
            };

            var TownHome = new House("TownHome")
            {
                BuildingType = "House",
                NumberofRoom = 10,
                ConstructionMaterial = "Brick",
                Height = 44,
                Width = 25,
                Length = 50,
                Floors = 3,
                Bedrooms = 4,
                Bathrooms = 3,
                Address1 = "145 8th Street North",
                Address2 = " ",
                City = "St. Petersburg",
                State = "Florida",
                Zip = "33701",
            };

            var Natwest = new Bank("Natwest")
            {
                BuildingType = "Bank",
                NumberofRoom = 5,
                ConstructionMaterial = "Brick",
                Height = 16,
                Width = 25,
                Length = 50,
                Floors = 1,
                Bathrooms = 2,
                Address1 = "145 2nd Ave South",
                Address2 = " ",
                City = "St. Petersburg",
                State = "Florida",
                Zip = "33701",
            };

            var RoyalBank = new Bank("RoyalBank")
            {
                BuildingType = "Bank",
                NumberofRoom = 8,
                ConstructionMaterial = "Concrete",
                Height = 32,
                Width = 35,
                Length = 55,
                Floors = 2,
                Bathrooms = 2,
                Address1 = "901 2nd Ave North",
                Address2 = " ",
                City = "St. Petersburg",
                State = "Florida",
                Zip = "33701",
            };

            var SmithAcademy = new School("SmithAcademy")
            {
                BuildingType = "School",
                NumberofRoom = 30,
                ConstructionMaterial = "Concrete",
                Height = 32,
                Width = 55,
                Length = 90,
                Floors = 2,
                Bathrooms = 15,
                Address1 = "1112 88th Street",
                Address2 = " ",
                City = "St. Petersburg",
                State = "Florida",
                Zip = "33650",
                NumberOfStudents = 50,

            };

            var Hogwarts = new School("Hogwarts")
            {
                BuildingType = "School",
                NumberofRoom = 30,
                ConstructionMaterial = "Magic",
                Height = 50,
                Width = 72,
                Length = 90,
                Floors = 4,
                Bathrooms = 15,
                Address1 = "Hogwarts Castle",
                Address2 = "1 Royal Mile",
                City = "Edinburgh",
                State = "Scotland",
                Zip = "G32 15D",
                NumberOfStudents = 150,

            };

           

        }   
    }
}
