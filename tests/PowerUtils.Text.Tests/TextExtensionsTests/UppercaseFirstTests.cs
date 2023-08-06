using FluentAssertions;
using Xunit;

namespace PowerUtils.Text.Tests.TextExtensionsTests
{
    public class UppercaseFirstTests
    {
        [Fact]
        public void Null_UppercaseFirst_Null()
        {
            // Arrange
            string input = null;


            // Act
            var act = input.UppercaseFirst();


            // Assert
            act.Should()
                .BeNull();
        }

        [Fact]
        public void Empty_UppercaseFirst_Empty()
        {
            // Arrange
            var input = "";


            // Act
            var act = input.UppercaseFirst();


            // Assert
            act.Should()
                .BeEmpty();
        }

        [Fact]
        public void SpaceFirstCharacter_UppercaseFirst_EqualsInput1()
        {
            // Arrange
            var input = " Hello world!!!";


            // Act
            var act = input.UppercaseFirst();


            // Assert
            act.Should()
                .Be(input);
        }

        [Fact]
        public void StringLowercase_UppercaseFirst_UpperFirstCharacter()
        {
            // Arrange
            var input = "hello world!!!";


            // Act
            var act = input.UppercaseFirst();


            // Assert
            act.Should()
                .Be("Hello world!!!");
        }

        [Fact]
        public void FirstCharacterUpper_UppercaseFirst_UpperFirstCharacter()
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
