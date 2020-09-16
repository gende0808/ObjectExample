using System;
using System.Collections.Generic;

namespace ObjectExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> listOfAccounts = new List<Account>();
            listOfAccounts.Add(new Account(1, "Gregory", "password", 29));
            listOfAccounts.Add(new Account(2, "BoB", "password", 12));
            listOfAccounts.Add(new Account(3, "Jos", "password", 95));
            listOfAccounts.Add(new Account(4, "Wouter", "password", 2));
            listOfAccounts.Add(new Account(5, "Jeroen", "password", 13));

            Account youngestPerson = listOfAccounts[0];
            foreach (Account ac in listOfAccounts) 
            {
                if(youngestPerson.age > ac.age)
                {
                    youngestPerson = ac;
                }
            }
            Console.WriteLine(youngestPerson.name);
        }
    }
    class Account
    {
        public int id;
        public string name;
        public string password;
        public int age;


        public Account(int id, string name, string password, int age)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.age = age;
        }
    }
}