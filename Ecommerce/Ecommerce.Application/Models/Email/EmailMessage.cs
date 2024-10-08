// ====================================================
// File: EmailMessage.cs
// Description: Configuration for email sender.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

namespace Ecommerce.Application.Models.Email;

public class EmailMessage
{
    public string To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
}
