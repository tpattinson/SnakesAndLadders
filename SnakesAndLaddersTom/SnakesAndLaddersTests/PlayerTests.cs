using NSubstitute;
using SnakesAndLaddersTom;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SnakesAndLaddersTests
{
    public class PlayerTests
    {
        [Fact]
        public void GivenAPlayerIsOnSquareOne_WhenTheyRollAThree_ThenTheirPositionShouldBeFour()
        {
            // arrange
            var dice = Substitute.For<iDice>();
            dice.Roll().Returns(3);

            var player = new Player(dice);
            player.position = 1;

            // act
            player.Move();

            // assert
            Assert.Equal(4, player.position);
        }

        [Fact]
        public void GivenTheTokenIsOnSquareOne_WhenTheTokenIsMovedThreeSpaces_AndThenItIsMovedFourSpaces_ThenTheTokenIsOnSquareEight()
        {
            // arrange
            var dice = Substitute.For<iDice>();
            dice.Roll().Returns(3);

            var player = new Player(dice);
            player.position = 1;

            // act
            player.Move();
            dice.Roll().Returns(4);
            player.Move();

            // assert
            Assert.Equal(8, player.position);
        }

        [Fact]
        public void GivenANewPlayer_WhenThereHaveBeenNoOtherMoves_ThenTheTokenShouldBeOnSquareOne()
        {
            // arrange
            var dice = Substitute.For<iDice>();
            var player = new Player(dice);

            // act


            // assert
            Assert.Equal(1, player.position);
        }

        [Fact]
        public void GivenTheTokenIsOnSquare97_WhenTheTokenIsMoved3Spaces_ThenTheTokenIsOnSquare100AndThePlayerHasWonTheGame()
        {
            // arrange
            var dice = Substitute.For<iDice>();
            dice.Roll().Returns(3);

            var player = new Player(dice);
            player.position = 97;

            // act
            player.Move();

            // assert
            Assert.Equal(100, player.position);
            Assert.True(player.isWinner);
        }

        [Fact]
        public void GivenTheTokenIsOnSquare97_WhenTheTokenIsMoved4Spaces_ThenTheTokenIsOnSsquare97AndThePlayerHasNotWonTheGame()
        {
            // arrange
            var dice = Substitute.For<iDice>();
            dice.Roll().Returns(4);

            var player = new Player(dice);
            player.position = 97;

            // act
            player.Move();

            // assert
            Assert.Equal(97, player.position);
            Assert.False(player.isWinner);
        }
    }
}
