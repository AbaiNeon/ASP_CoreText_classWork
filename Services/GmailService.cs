using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GmailService : IEmailService
    {
        public Task SendPlainEmail(string to, string title, string text)
        {
            throw new NotImplementedException();
        }
    }
}
