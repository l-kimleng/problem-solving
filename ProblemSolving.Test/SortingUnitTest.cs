using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolving.Lib;

namespace ProblemSolving.Test
{
    [TestClass]
    public class SortingUnitTest
    {
        [TestMethod]
        public void Sorting_SelectionSort_ReturnElementsAscending()
        {
            // Arrange
            var elements = new int[] { 1, -5, 4, 10, -9, 1, 0, 20, -8, 100, 1 };
            var expectedElements = new int[] { -9, -8, -5, 0, 1, 1, 1, 4, 10, 20, 100 };
            // Act
            var sortedElements = Sorting.SelectionSort(elements);
            // Assert
            CollectionAssert.AreEqual(sortedElements, expectedElements);
        }
    }
}
