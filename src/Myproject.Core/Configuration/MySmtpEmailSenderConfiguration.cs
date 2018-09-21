using Abp.Configuration;
using Abp.Dependency;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Configuration
{
   public  class MySmtpEmailSenderConfiguration : EmailSenderConfiguration, ISmtpEmailSenderConfiguration, ITransientDependency
    {
        public virtual string Host => GetNotEmptySettingValue(MyEmailSettingNames.Smtp.Host);
        public virtual int Port => SettingManager.GetSettingValue<int>(MyEmailSettingNames.Smtp.Port);
        public virtual string UserName => GetNotEmptySettingValue(MyEmailSettingNames.Smtp.UserName);
        public virtual string Password => GetNotEmptySettingValue(MyEmailSettingNames.Smtp.Password);
        public virtual string Domain => SettingManager.GetSettingValue(MyEmailSettingNames.Smtp.Domain);
        public virtual bool EnableSsl => SettingManager.GetSettingValue<bool>(MyEmailSettingNames.Smtp.EnableSsl);
        public virtual bool UseDefaultCredentials => SettingManager.GetSettingValue<bool>(MyEmailSettingNames.Smtp.UseDefaultCredentials);

        public MySmtpEmailSenderConfiguration(ISettingManager settingManager): base(settingManager)
        {
        }

    }
}
