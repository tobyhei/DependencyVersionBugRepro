using Microsoft.Extensions.Caching.Memory;

namespace DependencyVersionBugRepro.Console
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class HasACache
    {
        private readonly MemoryCache cache;

        public HasACache(MemoryCache cache) => this.cache = cache;
    }
}
