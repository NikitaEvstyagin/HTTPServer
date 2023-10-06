using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPServer.Hadlers
{
    public class ConrollerHandler : Handler
    {
        public override void HandleRequest(int condition)
        {
            // некоторая обработка запроса

            if (condition == 2)
            {
                // завершение выполнения запроса;
            }
            // передача запроса дальше по цепи при наличии в ней обработчиков
            else if (condition != null)
            {
                Successor.HandleRequest(condition);
            }
        }
    }
}
