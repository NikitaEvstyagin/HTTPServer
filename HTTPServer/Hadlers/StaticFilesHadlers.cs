using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HTTPServer.Hadlers
{
    public class StaticFilesHadlers : Handler
    {
        public override void HandleRequest(HttpListenerContext context)
        {
            // некоторая обработка запроса

            //TODO
            // нормальную логику
            if (!context.Request.Url!.AbsolutePath.EndsWith(".html"))
            {
                // получение файла из папки статик;
            }
            // передача запроса дальше по цепи при наличии в ней обработчиков
            else if (Successor != null)
            {
                Successor.HandleRequest(context);
            }
        }
        
    }
}
