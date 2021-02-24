using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBlazorApp.Data
{
    public class MockPlantProvider
    {

        public MockPlantProvider()
        {
            //assign PlantModels here
        }

        private PlantModel[] PlantModels;

        public Task<PlantModel[]> GetPlantModelAsync() //needs two parameters. one for the starting index and one for the max amount of data to return
        {
            //for now just return items with the index 0 - 5 from PlantModels and store the new local variable below
            PlantModel[] returnList = new PlantModel[5]; // change out the 5 for the variable that represents the max amount. However, test using the static 5 first to verify it works

            //use for loop here to fill returnList

            return Task.FromResult(returnList);

           PlantModels = new PlantModel[]
            {
                new PlantModel()
                {
                    Name = "Rainier Cherry",
                    Type = "Fruit Tree",
                    Zone = "5-8",
                    Description = "Delicious Yellow Cherries",
                    Price = "$10"
                },
                new PlantModel()
                {
                    Name = "Meyer Lemon",
                    Type = "Fruit Tree",
                    Zone = "8-11",
                    Description = "Tasty Lemons",
                    Price = "$12"
                },
                new PlantModel()
                {
                    Name = "Blackberry",
                    Type = "Shrub",
                    Zone = "7-9",
                    Description = "The Juciest Blackberries You've Ever Experienced.",
                    Price = "$8"
                },
                 new PlantModel()
                {
                    Name = "Dwarf Balsam Fir",
                    Type = "Ornamental Tree",
                    Zone = "3-6",
                    Description = "Bitchin Decorative Coniferous Tree",
                    Price = "$15"
                },
                 new PlantModel()
                {
                    Name = "Pixie Crunch Apple",
                    Type = "Fruit Tree",
                    Zone = "5-8",
                    Description = "Sweeter Than 'Honeycrisp'",
                    Price = "$40"
                },
                 new PlantModel()
                {
                    Name = "Asparagus",
                    Type = "Vegetable",
                    Zone = "3-8",
                    Description = "Makes Your Pee Smell Funny",
                    Price = "$20"
                },
                 new PlantModel()
                {
                    Name = "Sweet Corn",
                    Type = "Vegetable",
                    Zone = "3-9",
                    Description = "Corny",
                    Price = "$10"
                },
                 new PlantModel()
                {
                    Name = "Hybrid Tea Rose",
                    Type = "Flowering Shrub",
                    Zone = "4-10",
                    Description = "Lovely Red Edged White Blooms",
                    Price = "$30"
                },
                 new PlantModel()
                {
                    Name = "Sugar Maple",
                    Type = "Shade Tree",
                    Zone = "3-8",
                    Description = "Maple Syrup, Anyone?",
                    Price = "$20"
                },
                 new PlantModel()
                {
                    Name = "Pecan Tree",
                    Type = "Nut Tree",
                    Zone = "5-8",
                    Description = "We Just Pecan't Even",
                    Price = "$12"
                },
                 new PlantModel()
                {
                    Name = "Weeping Willow",
                    Type = "Shade Tree",
                    Zone = "6-8",
                    Description = "This Tree Received Zero Stars. Nobody likes a crybaby.",
                    Price = "$20"
                },
                 new PlantModel()
                {
                    Name = "Sunflower Seed Blend",
                    Type = "Flower Seeds",
                    Zone = "3-9",
                    Description = "A Fuckton of Sunflowers",
                    Price = "$9"
                },
                 new PlantModel()
                {
                    Name = "Hummingbird Mint Plant",
                    Type = "Flower Seeds",
                    Zone = "5-10",
                    Description = "For When You Want All The Birds",
                    Price = ""
                },
                 new PlantModel()
                {
                    Name = "Ice Cream Banana",
                    Type = "Fruit Tree",
                    Zone = "8-11",
                    Description = "The Good Kind of Vanilla",
                    Price = "$30"
                },
                 new PlantModel()
                {
                    Name = "Luffa Gourd",
                    Type = "Vegetable Seeds",
                    Zone = "3-9",
                    Description = "Grow Your Own Sponges",
                    Price = "$4"
                },
                 new PlantModel()
                {
                    Name = "Air Plant",
                    Type = "Decorative",
                    Zone = "9-11",
                    Description = "For Those Who Can't Remember To Water Their Plants",
                    Price = "$5"
                },
                 new PlantModel()
                {
                    Name = "Aloe Vera",
                    Type = "Succulent",
                    Zone = "8-11",
                    Description = "Great for Clumsy Chefs or Burn Victims",
                    Price = "$8"
                },
                 new PlantModel()
                {
                    Name = "Birdhouse Gourds",
                    Type = "Vegetable Seeds",
                    Zone = "3-9",
                    Description = "For When You Want Even More Birds",
                    Price = "$5"
                },
                 new PlantModel()
                {
                    Name = "Crape Myrtle",
                    Type = "Flowering Shrub",
                    Zone = "6-10",
                    Description = "The Ugliest Shrub You've Ever Seen",
                    Price = "$25"
                },
                  new PlantModel()
                {
                    Name = "White Spruce",
                    Type = "Shade Tree",
                    Zone = "2-6",
                    Description = "Smells Nice",
                    Price = "$25"
                }
            }).ToArray());
        }
    }
}