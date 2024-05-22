using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.Services
{
    public class GenerateNumbersService
    {
        Random _random = new Random();  
        public GenerateNumbersService() 
        {
        }

        public long GenerateRandomNumber(int length)
        {
            const string digits = "123456789";
            var result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                result.Append(digits[_random.Next(digits.Length)]);
            }

            return long.Parse(result.ToString());
        }

        public long GenerateRandomNumberForCVV() // hay que cambiar el tipo byte a int en bdd, momentaneamente se hace el metodo para guardar igual
        {
            const string digits = "123456789";
            var result = new StringBuilder(3);

            for (int i = 0; i < 2; i++)
            {
                result.Append(digits[_random.Next(digits.Length)]);
                if(i == 0) 
                {
                    result.Append(digits[_random.Next(2)]);
                }
                if(i == 1) 
                {
                    result.Append(digits[_random.Next(4)]);
                }
            }

            return long.Parse(result.ToString());
        }
    }
}
