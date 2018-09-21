using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Configuration
{
    public static class MyEmailSettingNames
    {
        public const string DefaultFromAddress = "Tenant.DefaultFromAddress";
        public const string DefaultFromDisplayName = "Tenant.DefaultFromDisplayName";

        public static class Smtp
        {
            public const string Host = "Tenant.Smtp.Host";
            public const string Port = "Tenant.Smtp.Port";
            public const string UserName = "Tenant.Smtp.UserName";
            public const string Password = "Tenant.Smtp.Password";
            public const string Domain = "Tenant.Smtp.Domain";
            public const string EnableSsl = "Tenant.Smtp.EnableSsl";
            public const string UseDefaultCredentials = "Tenant.Smtp.UseDefaultCredentials";
        }
    }
}
