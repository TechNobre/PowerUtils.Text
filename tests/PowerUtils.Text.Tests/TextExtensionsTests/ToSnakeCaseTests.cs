namespace PowerUtils.Text.Tests.TextExtensionsTests;

[Trait("Extension", "ToSnakeCase")]
public class ToSnakeCaseTests
{
    [Theory(DisplayName = "Converto a text to snake case")]
    [InlineData(null, null)]
    [InlineData("", "")]
    [InlineData("TestSC", "test_sc")]
    [InlineData("testSC", "test_sc")]
    [InlineData("TestSnakeCase", "test_snake_case")]
    [InlineData("testSnakeCase", "test_snake_case")]
    [InlineData("TestSnakeCase123", "test_snake_case123")]
    [InlineData("_testSnakeCase123", "_test_snake_case123")]
    [InlineData("test_SC", "test_sc")]
    [InlineData("Test", "test")]
    [InlineData("TEST", "test")]
    [InlineData("Test Snake Case", "test_snake_case")]
    [InlineData("TEST SNAKE CASE", "test_snake_case")]
    [InlineData("Test  Snake Case", "test_snake_case")]
    [InlineData("Test SnakeCase", "test_snake_case")]
    [InlineData("Test Snake111 Case", "test_snake111_case")]
    [InlineData("TEST SNAKE111 CASE", "test_snake111_case")]
    [InlineData("Test Snake Case 111", "test_snake_case_111")]
    [InlineData("Test 123 Case 111", "test_123_case_111")]
    [InlineData("Test123 Case 111", "test123_case_111")]
    [InlineData("Test 123Case 111", "test_123case_111")]
    [InlineData("Test 123Case__", "test_123case__")]
    [InlineData("Test 123Case1__", "test_123case1__")]
    public void ToSnakeCase(string input, string expected)
    {
        // Arrange &&  Act
        var act = input.ToSnakeCase();


        // Assert
        act.Should()
            .Be(expected);
    }
}
