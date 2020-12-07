using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace LongestKebab
{
    internal class Recipe
    {
        public Recipe(double groundLamb)
        {
            //Ground Lamb in Pounds
            GroundLamb = groundLamb;
            SmallOnion = 2 * groundLamb;
            ClovesGarlic = 8 * groundLamb;
            TeaspoonsGroundCumin = 3 * groundLamb;
            TeaspoonsGroundSumac = 3 * groundLamb;
            TeaspoonsSalt = 1 * groundLamb;
            GroundBlackPepper = 0.5 * groundLamb;
            RedPepperFlakes = 0.5 * groundLamb;
            TablespoonsWater = 4 * groundLamb;
            People = 8 * groundLamb;
            Length = 20 * 8 * groundLamb / 100;

        }

        //1 pound ground lamb
        public double GroundLamb { get; set; }
        //1 small onion(minced)
        public double SmallOnion { get; set; }
        //4 cloves garlic(minced)
        public double ClovesGarlic { get; set; }
        //1 1/2 teaspoons ground cumin(divided)
        public double TeaspoonsGroundCumin { get; set; }
        //1 1/2 teaspoons ground sumac(divided)
        public double TeaspoonsGroundSumac { get; set; }
        //1/2 teaspoon salt
        public double TeaspoonsSalt { get; set; }
        //1/4 teaspoon ground black pepper
        public double GroundBlackPepper { get; set; }
        //1/4 teaspoon red pepper flakes(or to taste)
        public double RedPepperFlakes { get; set; }
        //2 tablespoons water(ice cold)
        public double TablespoonsWater { get; set; }
        public double People { get; set; }
        public double Length { get; set; }

        public string CreateRecipeMessage()
        {
            var result = $"Here is your recipe: {Environment.NewLine}" +
                         $"{GroundLamb} pound(s) ground Lamb{Environment.NewLine}" +
                         $"{SmallOnion} small onion(s), minced{Environment.NewLine}" +
                         $"{ClovesGarlic} cloves of garlic, minced{Environment.NewLine}" +
                         $"{TeaspoonsGroundCumin} teaspoons ground cumin(divided){Environment.NewLine}" +
                         $"{TeaspoonsGroundSumac} teaspoons ground sumac(divided){Environment.NewLine}" +
                         $"{TeaspoonsSalt} teaspoon salt{Environment.NewLine}" +
                         $"{GroundBlackPepper} teaspoon ground black pepper{Environment.NewLine}" +
                         $"{RedPepperFlakes} teaspoon red pepper flakes(or to taste){Environment.NewLine}" +
                         $"{TablespoonsWater} tablespoons water(ice cold){Environment.NewLine}" +
                         $"{Environment.NewLine}" +
                         $"This will feed {People} people and can be approximately {Length} meters long";


            return result;
        }
    }
}
