// ====================================================
// File: EmailSettings.cs
// Description: Configuration for email sender.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

namespace Ecommerce.Application.Models.Email;

public class EmailSettings
{
    public string ApiKey { get; set; }
    public string FromAddress { get; set; }
    public string FromName { get; set; }
}
