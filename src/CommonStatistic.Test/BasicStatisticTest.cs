using System;
using System.Collections;
using System.Collections.Generic;
using Demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonStatistic.Test
{
    [TestClass]
    public class BasicStatisticTest
    {
        [TestMethod]
        public void TestGetMediumNumber()
        {
            List<Item> items = new List<Item>
            {
                new Item(){ Id = 1, Name = "Adam" },
                new Item(){ Id = 5, Name = "Eric" },
                new Item(){ Id = 6, Name = "French" },
                new Item(){ Id = 7, Name = "Grand" },
                new Item(){ Id = 8, Name = "Harry" },
                new Item(){ Id = 2, Name = "Billy" },
                new Item(){ Id = 3, Name = "Cecil" },
                new Item(){ Id = 4, Name = "Doris" }
            };

            var mid = BasicStatistic.GetMediumElement(items, new ItemComparer());

            var large = BasicStatistic.GetKthLargestElement(items,3, new ItemComparer());

            var small = BasicStatistic.GetKthSmallestElement(items, 3, new ItemComparer());

        }
    }
}
