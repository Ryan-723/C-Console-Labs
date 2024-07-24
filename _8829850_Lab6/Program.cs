namespace __8829850_Lab6;

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
class Program{

    static void Main()
    {
        LoadList();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Person");
            Console.WriteLine("2. Show People List");
            Console.WriteLine("3. Save List");
            Console.WriteLine("4. Load Peoples List");
            Console.WriteLine("5. Exit");

            Console.Write("Pick an option: ");
            string choice = Console.ReadLine();

            if(choice=="1")
            {
                AddPerson();
            }
            if(choice=="2")
            {
                ListPeople();
            }
            if(choice=="3")
            {
                SaveList();
            }
            if(choice=="4")
            {
                LoadList();
            }
            if(choice=="5")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please pick a valid option.");
            }
        }
    }
    
    static List<Person> peopleList = new List<Person>();

    static void AddPerson()
    {
        Console.WriteLine("Enter the First Name:");
        string fName = Console.ReadLine();
        Console.WriteLine("Enter the Last Name:");
        string lName = Console.ReadLine();
        Console.WriteLine("Enter the Date Of Birth");
        string dateOfBirth = Console.ReadLine();
        Console.WriteLine("Enter the Address:");
        string address = Console.ReadLine();
        Console.WriteLine("Enter the City Name:");
        string city = Console.ReadLine();
        Console.WriteLine("Enter the Country Name:");
        string country = Console.ReadLine();
        Console.WriteLine("Enter the Province Name:");
        string province = Console.ReadLine();

        Person person = new Person
        {
            FirstName = fName,
            LastName = lName,
            Birthdate = dateOfBirth,
            Address = address,
            City = city,
            Country = country,
            Province = province
        };

        peopleList.Add(person);
        Console.WriteLine("Person added!");
    }

    static void ListPeople(){
        foreach (var person in peopleList)
        {
            Console.WriteLine($"First Name: {person.FirstName} \n Last Name: {person.LastName} \n Date of Birth: {person.Birthdate} \n Address: {person.Address}\n City: {person.City} \n Province: {person.Province} \n Country: {person.Country} \n ");
        }
    }

    static void SaveList()
    {
        string jsonFile = JsonConvert.SerializeObject(peopleList, Formatting.Indented);
        File.WriteAllText("User_Data.json", jsonFile);
        Console.WriteLine("List saved successfully!");
    }

    static void LoadList()
    {
        try
        {
            string jsonFile = File.ReadAllText("User_Data.json");
            peopleList = JsonConvert.DeserializeObject<List<Person>>(jsonFile);
            Console.WriteLine("List loaded successfully!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No File found.");
            peopleList = new List<Person>();
        }
    }
} 

    

