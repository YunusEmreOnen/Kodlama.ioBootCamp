using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //Yapıcı metotlarda metot overloadı sırasında kendi kendimizi tekrar etmemek için
        //this anahtar sözcüğü ile belirlenen parametre için sınıfın farklı bir yapıcı metotdu
        //çağrılabilir.
        public Result(bool success, string message):this(success)
        {
            Message = message;           
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success
        {
            get;
        }

        public string Message
        { 
            get;
        }
    }
}
