using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class FileReader
{

    //Producing the output of the JSON file
    public void LoadJson(string path)
    {
        try
        {
            using (StreamReader r = new StreamReader(path))
            {
                var json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<MovieStar>>(json);
                foreach (var item in items)
                {
                    string age = $"{CalculateAge(item.DateOfBirth)}";
                    Console.WriteLine("{0} \n{1} \n{2} \n{3} \n{4} years old\n", item.Name, item.Surname, item.Sex, item.Nationality, age);
                }
            }

        }
        catch (System.IO.DirectoryNotFoundException e)
        {
            System.Console.WriteLine(e);
            System.Console.WriteLine($"The file doesn't exist in the destination \"{path}\" that you are trying to reach, check the input directory!");
        }
    }

    public int CalculateAge(string dob)
    {
        var parsedDate = DateTime.Parse(dob);
        int age = DateTime.Now.Year - parsedDate.Year;
        return age;
    }
}