using System;
using System.Collections.Generic;
using BeFit.Classes;
using NUnit.Framework;

namespace BeFit.Tests
{
    [TestFixture]
    public class ListIndexatorTests
    {
        [Test]
        public void ReturnTodayMealIndex_AddsAFewDayMeals_ReturnADayMealWithTodaysDate()
        {
            List<Day_Meals> list = new List<Day_Meals>();
           
            list.Add(new Day_Meals(DateTime.Now.AddDays(2)));
            var now = new Day_Meals(DateTime.Now);
            list.Add(now);
            list.Add(new Day_Meals(DateTime.Now.AddDays(-2)));
            list.Add(new Day_Meals(DateTime.Now.AddDays(1)));

            int index = List_Indexator.ReturnTodaysMealIndex(list);
            Assert.That(index == list.IndexOf(now));

        }
    }
}
