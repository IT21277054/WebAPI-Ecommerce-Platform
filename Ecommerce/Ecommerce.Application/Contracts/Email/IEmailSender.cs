using Ecommerce.Application.Models.Email;

namespace Ecommerce.Application.Contracts.Email;

public interface IEmailSender
{
    Task<bool> SendEmail(EmailMessage email);
}
