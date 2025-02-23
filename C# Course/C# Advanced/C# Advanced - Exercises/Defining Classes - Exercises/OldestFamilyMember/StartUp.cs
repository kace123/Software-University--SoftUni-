﻿using System;

namespace OldestFamilyMember
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                Person person = new Person()
                {
                    Name = input[0],
                    Age = int.Parse(input[1])
                };

                family.AddMember(person);
            }

            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
