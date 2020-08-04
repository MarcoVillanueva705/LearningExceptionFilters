using System;

namespace LearningExceptionFilters
{
    class PersonException : Exception
    {
        public PersonException(String name)
        {
            Name = name;
        }
        public String Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //throw new PersonException("Kim");
                throw new PersonException("Chap");
            }
            catch (PersonException ex)
            {
                if (ex.Name == "Kim")
                    Console.WriteLine("Hang up on them!");
                if(ex.Name == "Chap")
                    Console.WriteLine("It's chap!");

            }
        }
    }
}
