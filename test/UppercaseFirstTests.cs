using FluentAssertions;
using Xunit;

namespace PowerUtils.Text.Tests
{
    public class UppercaseFirstTests
    {
        [Fact(DisplayName = "String null should return null")]
        [Trait("Extension", "UppercaseFirst")]
        public void CompressText_Null_ReturnNull()
        {
            // Arrange
            string input = null;


            // Act
            var act = input.UppercaseFirst();


            // Assert
            act.Should()
                .BeNull();
        }

        [Fact(DisplayName = "String only empty should return empty")]
        [Trait("Extension", "UppercaseFirst")]
        public void UppercaseFirst_Empty_ReturnEmpty()
        {
            // Arrange
            var input = string.Empty;


            // Act
            var act = input.UppercaseFirst();


            // Assert
            act.Should()
                .BeEmpty();
        }

        [Fact(DisplayName = "String with spaces before text")]
        [Trait("Extension", "UppercaseFirst")]
        public void UppercaseFirst_LessMaxLength_ReturnEqualsInput1()
        {
            // Arrange
            var input = " Hello world!!!";


            // Act
            var act = input.UppercaseFirst();


            // Assert
            act.Should()
                .Be(input);
        }

        [Fact(DisplayName = "String with spaces before text")]
        [Trait("Extension", "UppercaseFirst")]
        public void UppercaseFirst_LessMaxLength_ReturnEqualsInput2()
        {
            // Arrange
            var input = " hello world!!!";


            // Act
            var act = input.UppercaseFirst();


            // Assert
            act.Should()
                .Be(input);
        }

        [Fact(DisplayName = "String lowercase")]
        [Trait("Extension", "UppercaseFirst")]
        public void UppercaseFirst_Lowercase_ReturnsupperFirstCharacter()
        {
            // Arrange
            var input = "hello world!!!";


            // Act
            var act = input.UppercaseFirst();


            // Assert
            act.Should()
                .Be("Hello world!!!");
        }

        [Fact(DisplayName = "String lowercase with first character already upper")]
        [Trait("Extension", "UppercaseFirst")]
        public void UppercaseFirst_AlreadyUpper_ReturnsupperFirstCharacter()
        {
            // Arrange
            var input = "Hello world!!!";


            // Act
            var act = input.UppercaseFirst();


            // Assert
            act.Should()
                .Be("Hello world!!!");
        }
    }
}