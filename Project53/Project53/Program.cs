using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace TupleProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Alice;85;2023-30-03,Bob;95;2023-20-08,Charlie;90;2022-30-09";
            List<Tuple> tuples = ParseInput(input);

            DateTime currentDate = DateTime.Now;
            DateTime lastYear = currentDate.AddYears(-1);

            var filteredTuples = tuples.Where(t => DateTime.ParseExact(t.Date, "yyyy-dd-MM", CultureInfo.InvariantCulture) >= lastYear)
                                       .OrderBy(t => t.Name)
                                       .ToList();

            double averageScore = filteredTuples.Any() ? filteredTuples.Average(t => t.Score) : 0;

            string output = GenerateOutput(filteredTuples, averageScore);
            Console.WriteLine(output);
        }

        static List<Tuple> ParseInput(string input)
        {
            var tuples = new List<Tuple>();
            var tupleStrings = input.Split(',');

            foreach (var tupleString in tupleStrings)
            {
                var tupleValues = tupleString.Split(';');
                if (tupleValues.Length == 3)
                {
                    string name = tupleValues[0];
                    int score = int.Parse(tupleValues[1]);
                    string date = tupleValues[2];

                    tuples.Add(new Tuple(name, score, date));
                }
            }

            return tuples;
        }

        static string GenerateOutput(List<Tuple> tuples, double averageScore)
        {
            string output = $"Average Score: {averageScore:F2}\n";

            foreach (var tuple in tuples)
            {
                output += $"{tuple.Name}, Score: {tuple.Score}, Date: {tuple.Date}\n";
            }

            return output;
        }
    }

    class Tuple
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public string Date { get; set; }

        public Tuple(string name, int score, string date)
        {
            Name = name;
            Score = score;
            Date = date;
        }
    }
}
