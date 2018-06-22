using DependencyVersionBugRepro.Api;
using DependencyVersionBugRepro.Console;
using Microsoft.Extensions.Caching.Memory;
using Xunit;

namespace DependencyVersionBugRepro.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // load the memory cache assembly
            MemoryCache cache = new MemoryCache(new MemoryCacheOptions());
            var hasACache = new HasACache(cache);
            var apiWithACache = new ApiWithACache(cache);
            Assert.True(true);
        }
    }
}
