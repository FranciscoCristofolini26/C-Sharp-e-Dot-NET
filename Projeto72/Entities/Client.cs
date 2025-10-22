using System;
using System.Reflection.Metadata.Ecma335;


namespace Exercicio.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {

        }

        public Client(string name, string email, DateTime birthdate)
        {
            Email = email;
            Name = name;
            BirthDate = birthDate;
        }
        
        public override string ToString()
        {
            return Name 
                + ", (" 
                + BirthDate.ToString("dd/MM/yyyy") 
                + ") - " 
                + Email;
        }
    }
}