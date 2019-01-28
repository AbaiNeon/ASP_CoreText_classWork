using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IEmailService
    {
        Task SendPlainEmail(string to, string title, string text);
    }
}
