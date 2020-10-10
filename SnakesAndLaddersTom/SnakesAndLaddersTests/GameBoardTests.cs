using SnakesAndLaddersTom;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SnakesAndLaddersTests
{
    public class GameBoardTests
    {
        [Fact]
        public void GivenThereIsAGameboard_WhenSetupIsRan_ThenThereShouldBeSixSnakes()
        {
            // arrange
            var gameboard = new GameBoard();

            // act
            gameboard.Setup(2);

            // assert
            Assert.Equal(6, gameboard._snakeList.Count);
        }

        [Fact]
        public void GivenThereIsAGameboard_WhenSetupIsRan_ThenThereShouldBeSixLadders()
        {
            // arrange
            var gameboard = new GameBoard();

            // act
            gameboard.Setup(2);

            // assert
            Assert.Equal(6, gameboard._ladderList.Count);
        }

        [Fact]
        public void GivenThereIsAGameboard_WhenTwoPlayersArePlaying_ThenThereShouldTwoPlayersSetup()
        {
            // arrange
            var gameboard = new GameBoard();

            // act
            gameboard.Setup(2);

            // assert
            Assert.Equal(2, gameboard._playerList.Count);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void GivenThereIsAGameboard_WhenZeroOrANegativeValueIsEntered_ThenThereShouldBeAnException(int invalidnumber)
        {
            // arrange
            var gameboard = new GameBoard();

            // act and assert
            Assert.Throws<Exception>(() => gameboard.Setup(invalidnumber));
        }

        [Fact]
        public void GivenThereIsAGameboard_WhenAPlayerTakesATurn_AndDoesNotWin_ThenGameContinues()
        {
            // arrange
            var gameboard = new GameBoard();
            gameboard.Setup(1);
            gameboard._playerList[0].isWinner = false;

            // act
            gameboard.TakeTurn();

            // assert
            Assert.False(gameboard.IsFinished);
        }

        [Fact]
        public void GivenThereIsAGameboard_WhenAPlayerTakesATurn_AndWins_ThenGameEnds()
        {
            // arrange
            var gameboard = new GameBoard();
            gameboard.Setup(1);
            gameboard._playerList[0].isWinner = true;

            // act
            gameboard.TakeTurn();

            // assert
            Assert.True(gameboard.IsFinished);
        }
    }
}
