using System.Reflection;

namespace AdventOfCode2021
{
    public abstract class Day<TPart1, TPart2>
    {
        public List<string> GetInput(string day, string file)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"AdventOfCode2021.{day}.{file}";

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                return result.Split(Environment.NewLine).Select(i => i.Trim()).ToList();
            }
        }

        public abstract TPart1 Part1(string input);
        public abstract TPart2 Part2(string input);
    }
}
