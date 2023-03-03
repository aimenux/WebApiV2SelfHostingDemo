using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Tests
{
    [Collection(TestServerCollection.Name)]
    public class IntegrationTests
    {
        private readonly TestServerFixture _httpServerFixture;

        public IntegrationTests(TestServerFixture httpServerFixture)
        {
            _httpServerFixture = httpServerFixture;
        }

        [Fact]
        public async Task Should_Get_Success_Response()
        {
            using (var client = _httpServerFixture.CreateHttpClient())
            {
                using (var response = await client.GetAsync("api/home"))
                {
                    response.Should().NotBeNull();
                    response.IsSuccessStatusCode.Should().BeTrue();
                    var responseBody = await response.Content.ReadAsStringAsync();
                    responseBody.Should().NotBeNullOrWhiteSpace();
                }
            }
        }
    }
}