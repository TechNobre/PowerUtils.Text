using System;
using FluentAssertions;
using Xunit;

namespace PowerUtils.Text.Tests.NetworkExtensionsTests
{
    public class CombineURLTests
    {
        [Fact]
        public void Null_URLCombine_ArgumentException()
        {
            // Arrange
            string root = null;


            // Act
            var act = Record.Exception(() => root.CombineURL());


            // Assert
            act.Should()
                .BeOfType<ArgumentException>();
        }

        [Fact]
        public void Empty_URLCombine_ArgumentException()
        {
            // Arrange
            var root = "";


            // Act
            var act = Record.Exception(() => root.CombineURL());


            // Assert
            act.Should()
                .BeOfType<ArgumentException>();
        }

        [Fact]
        public void WhiteSpace_URLCombine_ArgumentException()
        {
            // Arrange
            var root = "     ";


            // Act
            var act = Record.Exception(() => root.CombineURL());


            // Assert
            act.Should()
                .BeOfType<ArgumentException>();
        }

        [Fact]
        public void EmptySegments_URLCombine_ArgumentException()
        {
            // Arrange
            var root = "fake";
            var segments = Array.Empty<string>();


            // Act
            var act = root.CombineURL(segments);


            // Assert
            act.Should()
                .Be(root);
        }

        [Fact]
        public void NullSegments_URLCombine_ArgumentException()
        {
            // Arrange
            var root = "fake";
            string[] segments = null;


            // Act
            var act = root.CombineURL(segments);


            // Assert
            act.Should()
                .Be(root);
        }

        [Theory]
        [InlineData("fake", "fake")]
        [InlineData("www.fake.com", "www.fake.com")]
        [InlineData("https://www.fake.com", "https://www.fake.com")]
        [InlineData("https://fake.com", "https://fake.com")]
        public void URLWithoutSegments_URLCombine_CombinedURL(string url, string expected)
        {
            // Arrange & Act
            var act = url.CombineURL();


            // Assert
            act.Should()
                .Be(expected);
        }

        [Theory]
        [InlineData("fake", null, "fake")]
        [InlineData("www.fake.com", "fake", "www.fake.com/fake")]
        [InlineData("www.fake.com", "fake1/fake2/fake3", "www.fake.com/fake1/fake2/fake3")]
        [InlineData("https://www.fake.com", "fake", "https://www.fake.com/fake")]
        [InlineData("https://fake.com", "fake", "https://fake.com/fake")]
        public void URLWith1Segment_URLCombine_CombinedURL(string url, string segment, string expected)
        {
            // Arrange & Act
            var act = url.CombineURL(segment);


            // Assert
            act.Should()
                .Be(expected);
        }

        [Theory]
        [InlineData("fake", null, null, "fake")]
        [InlineData("www.fake.com", "fake1", "fake2", "www.fake.com/fake1/fake2")]
        [InlineData("www.fake.com", "fake1", null, "www.fake.com/fake1")]
        [InlineData("www.fake.com", null, "fake2", "www.fake.com/fake2")]
        [InlineData("https://www.fake.com", "fake1", "fake2", "https://www.fake.com/fake1/fake2")]
        [InlineData("https://fake.com", "fake1", "fake2", "https://fake.com/fake1/fake2")]
        [InlineData("http://localhost:8080", "clients", "photos", "http://localhost:8080/clients/photos")]
        public void URLWith2Segments_URLCombine_CombinedURL(string url, string segment1, string segment2, string expected)
        {
            // Arrange & Act
            var act = url.CombineURL(segment1, segment2);


            // Assert
            act.Should()
                .Be(expected);
        }
    }
}
