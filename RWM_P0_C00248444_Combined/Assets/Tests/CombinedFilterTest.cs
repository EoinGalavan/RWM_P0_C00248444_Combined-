using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 1, 3, 5, 7, 9, 12 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 4, 5, 16, 22, 28, 3 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}


