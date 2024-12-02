using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024.Solutions.Day_01_01
{
    public class Answer : IAnswer
    {
        public string PrintAnswer => GetAnswer("input.txt");

        private string GetAnswer(string inputFileName)
        {
            List<int> left = [], right = [];
            int totalDistance = 0;

            string path = Path.Combine(Environment.CurrentDirectory,
                nameof(AdventOfCode2024.Solutions),
                nameof(AdventOfCode2024.Solutions.Day_01_01),
                inputFileName);

            foreach (string line in File.ReadAllLines(path))
            {
                string[] parts = line.Split("   ");
                left.Add(int.Parse(parts[0]));
                right.Add(int.Parse(parts[1]));
            }

            left.Sort();
            right.Sort();

            for (int i = 0; i < left.Count; i++)
            {
                if (left[i] >= right[i])
                {
                    totalDistance += left[i] - right[i];
                }
                else
                {
                    totalDistance += right[i] - left[i];
                }
            }

            return $"{totalDistance}";
        }
    }
}
