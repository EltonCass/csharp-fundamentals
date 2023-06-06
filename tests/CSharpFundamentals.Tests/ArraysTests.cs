// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

using Fundamentals.Lesson4;
using System.Text.RegularExpressions;

namespace Fundamentals
{
    public class ArraysTests
    {
        [Fact]
        public void ArraysModifyArray_WhenInputValuesAreValid_UpdateValuesToArray()
        {
            //Arrange
            var currentArray = Arrays.Numbers;
            var finalValue = 100;
            var initialValue = 50;
            var inBetweenValue = -4;

            //Act
            Arrays.ModifyArray(finalValue, initialValue, inBetweenValue);

            //Assert
            Assert.Contains(finalValue, currentArray);
            Assert.Contains(initialValue, currentArray);
            Assert.Contains(inBetweenValue, currentArray);
        }

        [Theory]
        [InlineData(100, 50, -3)]
        [InlineData(130, 200, 333)]
        [InlineData(-30, -220, -73)]
        public void ArraysModifyArray_WhenInputValuesAreValid_UpdateValuesToArray_UsingInlineData(
            int appendedValue, int prependedValue, int inBetweenValue)
        {
            //Arrange
            var currentArray = Arrays.Numbers;

            //Act
            Arrays.ModifyArray(appendedValue, prependedValue, inBetweenValue);

            //Assert
            Assert.Contains(appendedValue, currentArray);
            Assert.Contains(prependedValue, currentArray);
            Assert.Contains(inBetweenValue, currentArray);
        }
    }
}
