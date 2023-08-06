using FluentAssertions;
using Xunit;

namespace PowerUtils.Text.Tests.TextExtensionsTests
{
    public class LowercaseFirstTests
    {
        [Fact]
        public void Null_LowercaseFirst_Null()
        {
            // Arrange
            string input = null;


            // Act
            var act = input.LowercaseFirst();


            // Assert
            act.Should()
                .BeNull();
        }

        [Fact]
        public void Empty_LowercaseFirst_Empty()
        {
            // Arrange
            var input = "";


            // Act
            var act = input.LowercaseFirst();


            // Assert
            act.Should()
                .BeEmpty();
        }

        [Fact]
        public void SpaceFirstCharacter_LowercaseFirst_EqualsInput()
        {
            // Arrange
            var input = " Hello world!!!";


            // Act
            var act = input.LowercaseFirst();


            // Assert
            act.Should()
                .Be(input);
        }

        [Fact]
        public void LowercaseFirst_LowercaseFirst_LowercaseFirst()
        {
            // Arrange
            var input = " hello world!!!";


            // Act
            var act = input.LowercaseFirst();


            // Assert
            act.Should()
                .Be(input);
        }

        [Fact]
        public void StringLowercase_LowercaseFirst_EqualsInput()
        {
            // Arrange
            var input = "hello world!!!";


            // Act
            var act = input.LowercaseFirst();


            // Assert
            act.Should()
                .Be("hello world!!!");
        }

        [Fact]
        public void UpperFirstCharacter_LowercaseFirst_LowerFirstCharacter()
        {
            // Arrange
            var input = "Hello world!!!";


            // Act
            var act = input.LowercaseFirst();


            // Assert
            act.Should()
                .Be("hello world!!!");
        }
    }
}
