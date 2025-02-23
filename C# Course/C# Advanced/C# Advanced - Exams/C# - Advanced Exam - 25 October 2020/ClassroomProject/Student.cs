﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomProject
{
    public class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Subject { get; private set; }

        public Student(string firstName, string lastName, string subject)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Subject = subject;
        }
        public override string ToString()
        {
            return $"Student: First Name = {this.FirstName}, Last Name = {this.LastName}, Subject = {this.Subject}";
        }
    }
}
