﻿using System.Net.Mail;

namespace BaseLibrary
{
    public static class BaseValidation
    {
        // Validate email address
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


    }
}
