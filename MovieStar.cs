using System;

public class MovieStar
{

    public MovieStar(string dob, string name, string surname, string sex, string nationality)
    {
        DateOfBirth = dob;
        Name = name;
        Surname = surname;
        Sex = sex;
        Nationality = nationality;
    }

    public string DateOfBirth { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Sex { get; set; }
    public string Nationality { get; set; }

}