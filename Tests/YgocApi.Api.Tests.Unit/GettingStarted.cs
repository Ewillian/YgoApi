using Microsoft.Playwright;
using NUnit.Framework;

namespace YgocApi.Api.Tests.Unit
{
    public class GettingStarted
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task Should_Be_TheFirstTest_OK()
        {
            using var playwright = await Playwright.CreateAsync();

            await using var browser = await playwright.Chromium.LaunchAsync();

            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://www.google.fr");
            await page.FillAsync("gLFyf", "toto");
            await page.ClickAsync("gNO89b");
        }
    }
}
