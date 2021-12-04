using AdventOfCode2021.Day2;
using Xunit;

namespace AdventOfCode2021.Test
{
    public class Day2Tests
    {
        [Fact]
        public void Example1_Part1()
        {
            var day2 = new Day2Solution();
            var result = day2.Part1("Example1.txt");
            Assert.Equal(150, result);
        }

        [Fact]
        public void MyInput_Part1()
        {
            var day2 = new Day2Solution();
            var result = day2.Part1("MyInput.txt");
            Assert.Equal(1728414, result);
        }

        [Fact]
        public void Example1_Part2()
        {
            var day2 = new Day2Solution();
            var result = day2.Part2("Example1.txt");
            Assert.Equal(900, result);
        }

        [Fact]
        public void MyInput_Part2()
        {
            var day2 = new Day2Solution();
            var result = day2.Part2("MyInput.txt");
            Assert.Equal(1765720035, result);
        }
    }
}