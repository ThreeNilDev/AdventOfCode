using System;

namespace AdventOfCode
{
	public class Day2
	{
        string[] input;
		public Day2()
		{
            Console.WriteLine("Hello Day 2");
            ReadTextFile();
            DisplayText();



        }

        void ReadTextFile()
        {
            string filePath = "@../../input2.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist :{0} ", filePath);
                return;
            }

            string[] textFromFile = File.ReadAllLines(filePath);
            input = textFromFile;

            return;
        }


        void DisplayText()
        {
            foreach (string game in input)
            {

                Console.WriteLine(game);
            }
        }


    }
}

