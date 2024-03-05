using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager(IApplicantService applicantService) : ISupplierService
    {
        public void GiveMask(Person person)
        { 
            if (applicantService.CheckPerson(person))
            {
                Console.WriteLine("Vatandaş Bilgileri doğrulandı");
                Console.WriteLine(person.Name + " için maske verildi!");
            }
            else
            {
                Console.WriteLine("Vatandaş Bilgileri doğrulanamadı!");
                Console.WriteLine(person.Name + " için maske verilemedi!");
            }
        }
    }
}
