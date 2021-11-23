using FluentAssertions;
using Xunit;

namespace PowerUtils.Text.Tests.TextExtensionsTests
{
    [Trait("Extension", "Truncate")]
    public class TruncateTests
    {
        [Fact(DisplayName = "String null should return null")]
        public void CompressText_Null_ReturnNull()
        {
            // Arrange
            string input = null;


            // Act
            var act = input.Truncate(50);


            // Assert
            act.Should()
                .BeNull();
        }

        [Fact(DisplayName = "String only empty should return empty")]
        public void Truncate_Empty_ReturnEmpty()
        {
            // Arrange
            var input = string.Empty;


            // Act
            var act = input.Truncate(50);


            // Assert
            act.Should()
                .BeEmpty();
        }

        [Fact(DisplayName = "String less max length should return the input")]
        public void Truncate_LessMaxLength_ReturnEqualsInput1()
        {
            // Arrange
            var input = "HelLo";
            var maxLength = 5;


            // Act
            var act = input.Truncate(maxLength);


            // Assert
            act.Should()
                .Be("HelLo");
            act.Should()
                .HaveLength(maxLength);
        }

        [Fact(DisplayName = "String less max length should return the input 1")]
        public void Truncate_LessMaxLength_ReturnEqualsInput2()
        {
            // Arrange
            var input = "HelLo";
            var maxLength = 5;


            // Act
            var act = input.Truncate(maxLength);


            // Assert
            act.Should()
                .Be("HelLo");
            act.Should()
                .HaveLength(maxLength);
        }


        [Fact(DisplayName = "String equals to max length should return the input")]
        public void Truncate_EqualsMaxLength_ReturnEqualsInput()
        {
            // Arrange
            var input = "Hello";
            var maxLength = 4;


            // Act
            var act = input.Truncate(maxLength);


            // Assert
            act.Should()
                .Be("Hell");
            act.Should()
                .HaveLength(maxLength);
        }

        [Fact(DisplayName = "String greater to max length should return the input")]
        public void Truncate_GreaterMaxLength_ReturnCompressedText1()
        {
            // Arrange
            var input = "Hello world!!!";
            var maxLength = 5;


            // Act
            var act = input.Truncate(maxLength);


            // Assert
            act.Should()
                .Be("Hello");
            act.Should()
                .HaveLength(maxLength);
        }

        [Fact(DisplayName = "String greater to max length should return the input")]
        public void Truncate_GreaterMaxLength_ReturnCompressedText2()
        {
            // Arrange
            var input = "Hello world!!!";
            var maxLength = 6;


            // Act
            var act = input.Truncate(maxLength);


            // Assert
            act.Should()
                .Be("Hello ");
            act.Should()
                .HaveLength(maxLength);
        }
    }
}