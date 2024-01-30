using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace Person
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Creiamo l'istanza Persona
            Persona myPersona = new Persona("Francesco", "Caputo", 30);
            Console.WriteLine(myPersona.GetName());
            Console.WriteLine(myPersona.GetSurname());
            Console.WriteLine(myPersona.GetAge());
            Console.WriteLine(myPersona.GetDettagli());
            Persona myPersona2 = new Persona();
            Console.WriteLine(myPersona2.GetDettagli());
        }

        public class Persona

        {

            //fields
            private string _name;
            private string _surname;
            private int _age;


            //Proprietà
            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    if (value.Length >= 4)
                    {
                        _name = value;
                    }

                    else
                    {
                        _name = "none";
                    }

                }

            }
            public string Surname { get; set; }



            public int Age
            {
                get
                {
                    return _age;
                }
                set

                {
                    if (value < 0)
                    {
                        _age = 0;
                    }
                    else
                    {
                        _age = value;
                    }
                }
            }


            // Costruttore


            public Persona(string name, string surname, int age)
            {
                Name = name;
                Surname = surname;
                Age = age;
            }

            public Persona()
            {
                Name = "Miles";
                Surname = "Davis";
                Age = 38;
            }

            //METODI

            public string GetName()
            {
                return $"My name is: {Name}";
            }

            public string GetSurname()
            {
                return $"My surname: {Surname}";
            }

            public int GetAge()
            {
                return Age;
            }

            public string GetDettagli()
            {
                return $"Name: {Name}, Surname: {Surname}, Age: {Age}";
            }
        }


    }
}