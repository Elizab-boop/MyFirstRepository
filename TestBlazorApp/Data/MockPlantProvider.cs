using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBlazorApp.Data
{
    public class MockPlantProvider
    {
        private PlantModel[] PlantModels;

        public MockPlantProvider()
        {
            PlantModels = new PlantModel[]
            {
                new PlantModel()
                {
                    ID = 1,
                    Name = "Rainier Cherry",
                    Type = "Fruit Tree",
                    Zone = "5-8",
                    Description = "Delicious Yellow Cherries",
                    Price = "$10"
                },
                new PlantModel()
                {
                    ID = 2,
                    Name = "Meyer Lemon",
                    Type = "Fruit Tree",
                    Zone = "8-11",
                    Description = "Tasty Lemons",
                    Price = "$12"
                },
                new PlantModel()
                {
                    ID = 3,
                    Name = "Blackberry",
                    Type = "Shrub",
                    Zone = "7-9",
                    Description = "The Juciest Blackberries You've Ever Experienced.",
                    Price = "$8"
                },
                 new PlantModel()
                {
                    ID = 4,
                    Name = "Dwarf Balsam Fir",
                    Type = "Ornamental Tree",
                    Zone = "3-6",
                    Description = "Bitchin Decorative Coniferous Tree",
                    Price = "$15"
                },
                 new PlantModel()
                {
                    ID = 5,
                    Name = "Pixie Crunch Apple",
                    Type = "Fruit Tree",
                    Zone = "5-8",
                    Description = "Sweeter Than 'Honeycrisp'",
                    Price = "$40"
                },
                 new PlantModel()
                {
                    ID = 6,
                    Name = "Asparagus",
                    Type = "Vegetable",
                    Zone = "3-8",
                    Description = "Makes Your Pee Smell Funny",
                    Price = "$20"
                },
                 new PlantModel()
                {
                    ID = 7,
                    Name = "Sweet Corn",
                    Type = "Vegetable",
                    Zone = "3-9",
                    Description = "Corny",
                    Price = "$10"
                },
                 new PlantModel()
                {
                    ID = 8,
                    Name = "Hybrid Tea Rose",
                    Type = "Flowering Shrub",
                    Zone = "4-10",
                    Description = "Lovely Red Edged White Blooms",
                    Price = "$30"
                },
                 new PlantModel()
                {
                    ID = 9,
                    Name = "Sugar Maple",
                    Type = "Shade Tree",
                    Zone = "3-8",
                    Description = "Maple Syrup, Anyone?",
                    Price = "$20"
                },
                 new PlantModel()
                {
                    ID = 10,
                    Name = "Pecan Tree",
                    Type = "Nut Tree",
                    Zone = "5-8",
                    Description = "We Just Pecan't Even",
                    Price = "$12"
                },
                 new PlantModel()
                {
                    ID = 11,
                    Name = "Weeping Willow",
                    Type = "Shade Tree",
                    Zone = "6-8",
                    Description = "This Tree Received Zero Stars. Nobody likes a crybaby.",
                    Price = "$20"
                },
                 new PlantModel()
                {

                    ID = 12,
                    Name = "Sunflower Seed Blend",
                    Type = "Flower Seeds",
                    Zone = "3-9",
                    Description = "A Fuckton of Sunflowers",
                    Price = "$9"
                },
                 new PlantModel()
                {
                    ID = 13,
                    Name = "Hummingbird Mint Plant",
                    Type = "Flower Seeds",
                    Zone = "5-10",
                    Description = "For When You Want All The Birds",
                    Price = ""
                },
                 new PlantModel()
                {
                    ID = 14,
                    Name = "Ice Cream Banana",
                    Type = "Fruit Tree",
                    Zone = "8-11",
                    Description = "The Good Kind of Vanilla",
                    Price = "$30"
                },
                 new PlantModel()
                {
                    ID = 15,
                    Name = "Luffa Gourd",
                    Type = "Vegetable Seeds",
                    Zone = "3-9",
                    Description = "Grow Your Own Sponges",
                    Price = "$4"
                },
                 new PlantModel()
                {
                    ID = 16,
                    Name = "Air Plant",
                    Type = "Decorative",
                    Zone = "9-11",
                    Description = "For Those Who Can't Remember To Water Their Plants",
                    Price = "$5"
                },
                 new PlantModel()
                {
                    ID = 17,
                    Name = "Aloe Vera",
                    Type = "Succulent",
                    Zone = "8-11",
                    Description = "Great for Clumsy Chefs or Burn Victims",
                    Price = "$8"
                },
                 new PlantModel()
                {
                    ID = 18,
                    Name = "Birdhouse Gourds",
                    Type = "Vegetable Seeds",
                    Zone = "3-9",
                    Description = "For When You Want Even More Birds",
                    Price = "$5"
                },
                 new PlantModel()
                {
                    ID = 19,
                    Name = "Crape Myrtle",
                    Type = "Flowering Shrub",
                    Zone = "6-10",
                    Description = "The Ugliest Shrub You've Ever Seen",
                    Price = "$25"
                },
                 new PlantModel()
                {
                    ID = 20,
                    Name = "White Spruce",
                    Type = "Shade Tree",
                    Zone = "2-6",
                    Description = "Smells Nice",
                    Price = "$25"
                }
            };
        }
        public Task<PlantModel[]> GetPlantModelAsync(int startValue, int amountOfItems)
        {
            //A bit advanced, but so much easier. 
            //We could also use a List<PlantModel>, which is less mathy and still uses loops like you're used to
            PlantModel[] returnList = PlantModels.Where(x => 
                (
                    x.ID >= startValue && 
                    x.ID < (startValue + amountOfItems))
                ).ToArray();

            return Task.FromResult(returnList);
        }
    }
}