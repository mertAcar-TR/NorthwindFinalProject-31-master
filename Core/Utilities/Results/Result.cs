using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
                                                    //2 parametreli gönderirsen otomatik olarak alttakide çalışır
        public Result(bool success, string message):this(success)
        {
            Message = message; //Böyle yaparak yazılımcının kendi kafasına göre değilde bir standarta göre kod yazmasını zorladık
            
        }
        public Result(bool success)
        {
            Success = success; //mesaj göndermek istemezsek diye overload yaptık
        }

        public bool Success {get;}

        public string Message  {get;} //Get only'ler constructor da set edilebilir
    }
}
