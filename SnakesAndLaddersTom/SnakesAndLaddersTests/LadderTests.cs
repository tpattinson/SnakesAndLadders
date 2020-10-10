using NSubstitute;
using SnakesAndLaddersTom;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SnakesAndLaddersTests
{
    public class LadderTests
    {
        [Fact]
        public void GivenThereIsALadderConnectingSquares2And12_WhenTheTokenLandsOnSquare2_ThenTheTokenIsOnSquare12()
        {
            // arrange
            var ladder = new Ladder(2,12);
            
            // act
            var result = ladder.Move(2);

            // assert
            Assert.Equal(12, result);
        }

        [Fact]
        public void GivenThereIsALadderConnectingSquares2And12_WhenTheTokenLandsOnSquare12_ThenTheTokenRemainsOnSquare12()
        {
            // arrange
            var ladder = new Ladder(2, 12);

            // act
            var result = ladder.Move(12);

            // assert
            Assert.Equal(12, result);
        }

        [Fact]
        public void GivenThereIsALadderConnectingSquares2And12_WhenTheTokenLandsOnSquare5_ThenTheTokenRemainsOnSquare5()
        {
            // arrange
            var ladder = new Ladder(2, 12);

            // act
            var result = ladder.Move(5);

            // assert
            Assert.Equal(5, result);
        }
    }
}
