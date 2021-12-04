using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day2
{
    public class Day2Solution : Day<int, int>
    {
        public override int Part1(string input)
        {
            var movements = GetInput("Day2", input).Select(i => FromString(i)).ToList();

            var horizontal = 0;
            var depth = 0;
            foreach(var movement in movements)
            {
                _ = movement switch
                {
                    ForwardCommand fwdCmd => horizontal += fwdCmd.Amount,
                    DownCommand downCmd => depth += downCmd.Amount,
                    UpCommand upCmd => depth -= upCmd.Amount,
                };
            }
            return horizontal * depth;
        }

        private IMovementCommand FromString(string input)
        {
            var splits = input.Split(" ");
            return splits[0] switch
            {
                "forward" => new ForwardCommand(int.Parse(splits[1])),
                "up" => new UpCommand(int.Parse(splits[1])),
                "down" => new DownCommand(int.Parse(splits[1]))
            };
        }

        public override int Part2(string input)
        {
            var movements = GetInput("Day2", input).Select(i => FromString(i)).ToList();

            var horizontal = 0;
            var depth = 0;
            var aim = 0;
            foreach (var movement in movements)
            {
                switch (movement)
                {
                    case ForwardCommand fwdCommand:
                        horizontal += fwdCommand.Amount;
                        depth += fwdCommand.Amount * aim;
                        break;
                    case DownCommand downCommand:
                        aim += downCommand.Amount;
                        break;
                    case UpCommand upCommand:
                        aim -= upCommand.Amount;
                        break;
                }
            }
            return horizontal * depth;
        }
    }

    public record ForwardCommand(int Amount) : IMovementCommand;

    public record UpCommand(int Amount) : IMovementCommand;

    public record DownCommand(int Amount) : IMovementCommand;
}
