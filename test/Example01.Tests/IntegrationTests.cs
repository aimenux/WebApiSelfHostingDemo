using System.Net;
using FluentAssertions;

namespace Example01.Tests;

public class IntegrationTests
{
    [Fact]
    public async Task Should_Get_Success_Response()
    {
        // arrange
        var fixture = new WebApiTestFixture();
        var client = fixture.CreateClient();

        // act
        var response = await client.GetAsync("/api");
        var responseBody = await response.Content.ReadAsStringAsync();

        // assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        responseBody.Should().NotBeNullOrWhiteSpace();
    }
}