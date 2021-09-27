using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 52, 70, 88, 11, 14, 52, 94 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
