using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using BeFit.Classes;

namespace BeFit.Tests
{
    
    [TestFixture]
    public class CalculateDemandsInGramsTests
    {
        [TestCase(1000,90,6,4,ExpectedResult = new int[] { 100,15,10})]
        [TestCase(2000, 0, 100, 0, ExpectedResult = new int[] { 0, 500, 0 })]
        
        public double[] CaltulateIngredients_CombinationGivesResultIntigersNumbers_ExpectedSimilarIntigersNumbers(double kcal,double fat,double carbo,double protein)
        {
            return CalculateDemandInGrams.CaltulateIngredients(kcal, fat, carbo, protein);
             
        }
        [TestCase(1000, 45, 44, 11, ExpectedResult = new double[] { 50, 110, 28 })]
        [TestCase(2500, 36, 9, 55, ExpectedResult = new double[] { 100, 56, 344 })]
        public double[] CaltulateIngredients_CombinationGivesResultAfterTheDecimalPoints_ExpectedRoundsNumbers(double kcal, double fat, double carbo, double protein)
        {
            return CalculateDemandInGrams.CaltulateIngredients(kcal, fat, carbo, protein);
        }







    }
}
