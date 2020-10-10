using SnakesAndLaddersTom;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SnakesAndLaddersTests
{
    public class DiceTests
    {
        [Fact]
        public void GivenADiceToRoll_ShouldReturnBetween1And6()
        {
            // arrange
            var dice = new Dice();

            // act
            var result = dice.Roll();

            // assert
            Assert.True(result > 0);
            Assert.True(result < 7);

        }

        [Fact]
        public void ShouldBePossibleToReturnEachNumberBetweenOneAndSix()
        {
            // arrange
            var dice = new Dice();
            var expectedValues = new List<int> { 1, 2, 3, 4, 5, 6 };
            var receivedValues = new List<int>();

            // act
            for (int i = 0; i < 150; i++)
            {
                var result = dice.Roll();
                if (receivedValues.Contains(result))
                    continue;
                else
                    receivedValues.Add(result);
            }
            // assert
            Assert.True(receivedValues.All(expectedValues.Contains));

        }
    }
}