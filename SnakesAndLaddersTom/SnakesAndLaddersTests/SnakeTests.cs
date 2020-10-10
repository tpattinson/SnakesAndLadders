using NSubstitute;
using SnakesAndLaddersTom;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SnakesAndLaddersTests
{
    public class SnakeTests
    {
        [Fact]
        public void GivenThereIsASnakeConnectingSquares2And12_WhenTheTokenLandsOnSquare12_ThenTheTokenIsOnSquare2()
        {
            // arrange
            var snake = new Snake(12,2);
            
            // act
            var result = snake.Move(12);

            // assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void GivenThereIsASnakeConnectingSquares2And12_WhenTheTokenLandsOnSquare2_ThenTheTokenRemainsOnSquare2()
        {
            // arrange
            var snake = new Snake(12, 2);

            // act
            var result = snake.Move(2);

            // assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void GivenThereIsASnakeConnectingSquares2And12_WhenTheTokenLandsOnSquare5_ThenTheTokenRemainsOnSquare5()
        {
            // arrange
            var snake = new Snake(12, 2);

            // act
            var result = snake.Move(5);

            // assert
            Assert.Equal(5, result);
        }
    }
}
