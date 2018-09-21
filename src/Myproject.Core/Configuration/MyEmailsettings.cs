using Abp.Configuration;
using Abp.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Configuration
{
    internal class MyEmailSettingProvider : SettingProvider
    {
        public override IEnumerable<SettingDefinition> GetSettingDefinitions(SettingDefinitionProviderContext context)
        {
            return new[]
            {
            new SettingDefinition(MyEmailSettingNames.Smtp.Host, "smtp.gmail.com", L("SmtpHost"), scopes: SettingScopes.Application | SettingScopes.Tenant),
            new SettingDefinition(MyEmailSettingNames.Smtp.Port, "587", L("SmtpPort"), scopes: SettingScopes.Application | SettingScopes.Tenant),
            new SettingDefinition(MyEmailSettingNames.Smtp.UserName, "kursatesim@gmail.com", L("Username"), scopes: SettingScopes.Application | SettingScopes.Tenant),
            new SettingDefinition(MyEmailSettingNames.Smtp.Password, "krstahmet1235", L("Password"), scopes: SettingScopes.Application | SettingScopes.Tenant),
            new SettingDefinition(MyEmailSettingNames.Smtp.Domain, "", L("DomainName"), scopes: SettingScopes.Application | SettingScopes.Tenant),
            new SettingDefinition(MyEmailSettingNames.Smtp.EnableSsl, "false", L("UseSSL"), scopes: SettingScopes.Application | SettingScopes.Tenant),
            new SettingDefinition(MyEmailSettingNames.Smtp.UseDefaultCredentials, "true", L("UseDefaultCredentials"), scopes: SettingScopes.Application | SettingScopes.Tenant),
            new SettingDefinition(MyEmailSettingNames.DefaultFromAddress, "", L("DefaultFromSenderEmailAddress"), scopes: SettingScopes.Application | SettingScopes.Tenant),
            new SettingDefinition(MyEmailSettingNames.DefaultFromDisplayName, "", L("DefaultFromSenderDisplayName"), scopes: SettingScopes.Application | SettingScopes.Tenant)
        };
        }

        private static LocalizableString L(string name)
        {
            return new LocalizableString(name, "");
        }
    }
}
