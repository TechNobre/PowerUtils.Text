using FluentAssertions;
using Xunit;

namespace PowerUtils.Text.Tests.TextExtensionsTests
{
    public class EmptyOrWhiteSpaceToNullTests
    {
        [Fact]
        public void Null_EmptyOrWhiteSpace_Null()
        {
            // Arrange
            string input = null;


            // Act
            var act = input.EmptyOrWhiteSpaceToNull();


            // Assert
            act.Should()
                .BeNull();
        }

        [Fact]
        public void Empty_EmptyOrWhiteSpace_Null()
        {
            // Arrange
            var input = "";


            // Act
            var act = input.EmptyOrWhiteSpaceToNull();


            // Assert
            act.Should()
                .BeNull();
        }

        [Fact]
        public void TwoSpaces_EmptyOrWhiteSpace_Null()
        {
            // Arrange
            var input = "  ";


            // Act
            var act = input.EmptyOrWhiteSpaceToNull();


            // Assert
            act.Should()
                .BeNull();
        }

        [Fact]
        public void WithWhiteSpaces_EmptyOrWhiteSpace_Null()
        {
            // Arrange
            var input = "       ";


            // Act
            var act = input.EmptyOrWhiteSpaceToNull();


            // Assert
            act.Should()
                .BeNull();
        }

        [Fact]
        public void Filled_EmptyOrWhiteSpace_EqualsInput()
        {
            // Arrange
            var input = " Hello world!!   ";


            // Act
            var act = input.EmptyOrWhiteSpaceToNull();


            // Assert
            act.Should()
                .Be(" Hello world!!   ");
        }
    }
}
