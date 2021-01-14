using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyVisionKl
{
    class Helper
    {
        public int Age(string birthDate)
        {
            var age = 0;

            Console.WriteLine("Nacimiento: " + birthDate);
            Console.WriteLine("Nacimiento: " + birthDate.Substring(0, 2));
            Console.WriteLine("Nacimiento: " + birthDate.Substring(3, 2));
            Console.WriteLine("Nacimiento: " + birthDate.Substring(6, 4));

            //Año, Mes, Dia
            DateTime fechaNacimiento = new DateTime(Convert.ToInt32(birthDate.Substring(6, 4)),
                                                    Convert.ToInt32(birthDate.Substring(0, 2)),
                                                    Convert.ToInt32(birthDate.Substring(3, 2)));

            DateTime now = DateTime.Today;
            age = DateTime.Today.Year - fechaNacimiento.Year;

            return age;
        }

        public String Genre(String value)
        {
            switch (value)
            {
                case "1":
                    return "Masculino";                    
                case "2":
                    return "Femenino";                    
                default:
                    return "";
            }            
        }
            

    }
}
