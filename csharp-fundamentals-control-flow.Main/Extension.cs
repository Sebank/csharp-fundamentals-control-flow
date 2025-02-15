﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_control_flow.Main
{
    public class Extension
    {


        public string timerStatus(int v)
        {
            switch (v)
            {
                case var expression when v > 0:
                    return ("The cake is still baking!");
                case 0:
                    return ("The cake is ready!");
                default:
                    return ("The timer finished ages ago!");
            }
        }


        //TODO: Extension 2: Estimate Prep Time
        /*  
            Create a method named estimatePrepTime that accepts two parameters:
            - an array of ingredients, e.g. ["sugar", "milk", "flour", "eggs"]
            - the prep time per ingredient in minutes
            The method must return the total prep time required based on the number of ingredients
            provided and the prep time per ingredient.
            If a prep time of 0 is provided, the method should assume each ingredient takes 2 minutes to prepare.
         */

        public int estimatePrepTime(string[] strings, int v)
        {

            return strings.Length * (v == 0 ? 2 : v);

        }



        //TODO: Extension 3: calculateGramsOfSugar that accepts two parameters 1 an array of ingredients that will always contain 3 ingredients AND  2 the number of layers the cake has. The cake will need 100g of sugar per layer, if that ingredient is present in the provided list of ingredients.             The method should return the number of grams of sugar needed to make the cake.
        /*  3.
            Create a method named calculateGramsOfSugar that accepts two parameters:
            - an array of ingredients that will always contain 3 ingredients
            - the number of layers the cake has
            The cake will need 100g of sugar per layer, if that ingredient is present in the provided list of ingredients.
            The method should return the number of grams of sugar needed to make the cake.
         */

        public double calculateGramsOfSugar(string[] strings, int v)
        {
            return (strings.Contains("sugar") ? v * 100 : 0);
        }
    }
}
