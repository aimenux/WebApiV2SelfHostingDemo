using System;
using System.Net.Http;
using App;
using Microsoft.Owin.Hosting;

namespace Tests
{
    public sealed class TestServerFixture : IDisposable
    {
        private readonly IDisposable _testServer;

        private const string BaseAddress = "http://localhost:5555/";

        public TestServerFixture()
        {
            _testServer = WebApp.Start<Startup>(BaseAddress);
        }

        public HttpClient CreateHttpClient() => new HttpClient
        {
            BaseAddress = new Uri(BaseAddress)
        };

        public void Dispose()
        {
            _testServer?.Dispose();
        }
    }
}