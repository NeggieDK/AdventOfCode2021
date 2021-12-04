using AdventOfCode2021.Day1;
using Xunit;

namespace AdventOfCode2021.Test
{
    public class Day1Tests
    {
        [Fact]
        public void Example1_Part1()
        {
            var day1 = new Day1Solution();
            var result = day1.Part1("Example1.txt");
            Assert.Equal(7, result);
        }

        [Fact]
        public void MyInput_Part1()
        {
            var day1 = new Day1Solution();
            var result = day1.Part1("MyInput.txt");
            Assert.Equal(1292, result);
        }

        [Fact]
        public void Example1_Part2()
        {
            var day1 = new Day1Solution();
            var result = day1.Part2("Example1.txt");
            Assert.Equal(5, result);
        }

        [Fact]
        public void MyInput_Part2()
        {
            var day1 = new Day1Solution();
            var result = day1.Part2("MyInput.txt");
            Assert.Equal(1262, result);
        }
    }
}