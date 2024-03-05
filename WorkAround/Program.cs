using System;
using Business.Concrete;
using Entities.Concrete;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var person = GetInformationWithConsole();
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person);
            
        }

        private static Person GetInformationWithConsole()
        {
            Console.WriteLine("Lütfen bilgilerinizi girin:");

            Console.Write("İsim: ");
            string isim = Console.ReadLine();

            Console.Write("Soyisim: ");
            string soyisim = Console.ReadLine();

            Console.Write("Doğum Yılı: ");
            int dogumYili;
            while (!int.TryParse(Console.ReadLine(), out dogumYili))
            {
                Console.WriteLine("Geçersiz yaş. Lütfen bir sayı girin.");
                Console.Write("Doğum Yılı: ");
            }

            Console.Write("TC Kimlik No: ");
            long tcNo;
            while (!long.TryParse(Console.ReadLine(), out tcNo))
            {
                Console.WriteLine("Geçersiz TC Kimlik No. Lütfen bir sayı girin.");
                Console.Write("TC Kimlik No: ");
            }
            Person person = new Person();
            person.Name = isim;
            person.Surname = soyisim;
            person.DateofBirthYear = dogumYili;
            person.NationalIdentity = tcNo;
            return person;
        }
    }
}


