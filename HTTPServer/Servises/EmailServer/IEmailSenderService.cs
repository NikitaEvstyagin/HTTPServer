using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPServer.Servises.EmailServer
{
    public interface IEmailSenderService
    {
        public Task SendEmailAsync(string city,
        string address,
        string profession,
        string name,
        string lastname,
        string birthday,
        string phone,
        string social);
    }
}
