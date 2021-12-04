namespace AdventOfCode2021.Day1
{
    public class Day1Solution : Day<int, int>
    {
        public override int Part1(string input)
        {
            var lines = GetInput("Day1", input).Select(i => int.Parse(i));
            var previousValue = 0;
            var amountIncreased = 0;
            foreach(var depth in lines)
            {
                if (previousValue != 0 && depth > previousValue) amountIncreased++;
                previousValue = depth;
            }
            return amountIncreased;
        }

        public override int Part2(string input)
        {
            var lines = GetInput("Day1", input).Select(i => int.Parse(i)).ToList();
            var amountIncreased = 0;
            for(var i = 0;i < lines.Count - 1; i++)
            {
                var current = lines[i];

                if(i + 1 < lines.Count)
                {
                    current += lines[i + 1];
                }

                if (i + 2 < lines.Count)
                {
                    current += lines[i + 2];
                }

                var next = lines[i + 1];

                if (i + 2 < lines.Count)
                {
                    next += lines[i + 2];
                }

                if (i + 3 < lines.Count)
                {
                    next += lines[i + 3];
                }

                if(next > current)
                {
                    amountIncreased++;  
                }
            }

            return amountIncreased;
        }
    }
}