using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace insenia_interview
{
    class Program
    {
        static void Main(string[] args)
        {

            //Simple Menu
            System.Console.WriteLine("Select one of the following options: \n1)Palidrome Case Insensitive \n2)Palidrome Case Sensitive \n3)MovieStar JSON");

            string input = Console.ReadLine();
            int choice;

            bool choice_check = Int32.TryParse(input, out choice);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    System.Console.WriteLine("Please enter a word: ");
                    //Get the input
                    string inputWord = Console.ReadLine().ToLower();

                    //Initialize Palidrom class
                    Palidrome palidrome = new Palidrome();

                    //Check the word
                    bool answer = palidrome.isPalidromeCaseSensitive(inputWord);

                    if (answer == true)
                    {
                        System.Console.WriteLine($"The word {inputWord} is palidrome");
                    }

                    else
                    {
                        System.Console.WriteLine("The word is not palidrome");
                    }
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    System.Console.WriteLine("Please enter a word: ");
                    //Get the input
                    string inputWord2 = Console.ReadLine();

                    //Initialize Palidrom class
                    Palidrome palidrome2 = new Palidrome();

                    //Check the word
                    bool answer2 = palidrome2.isPalidromCaseInSensitive(inputWord2);

                    if (answer2 == true)
                    {
                        System.Console.WriteLine($"The word {inputWord2} is palidrome");
                    }

                    else
                    {
                        System.Console.WriteLine("The word is not palidrome");
                    }
                    break;

                case 3:
                    string filename = "mock-data/input.json";

                    //Initialize custom class
                    FileReader fileReader = new FileReader();

                    //Print out the deserialized JSON
                    fileReader.LoadJson(filename);
                    break;
                default:
                    Console.WriteLine("Make your choice.");
                    break;
            }
        }
    }
}
