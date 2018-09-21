using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Modules;
using Abp.Net.Mail.Smtp;
using Abp.Zero;
using Abp.Zero.Configuration;
using Myproject.Authorization;
using Myproject.Authorization.Roles;
using Myproject.Authorization.Users;
using Myproject.Configuration;
using Myproject.MultiTenancy;

namespace Myproject
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class MyprojectCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            //Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            //Remove the following line to disable multi-tenancy.
            Configuration.MultiTenancy.IsEnabled = MyprojectConsts.MultiTenancyEnabled;

            //Add/remove localization sources here
            Configuration.Localization.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    MyprojectConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        Assembly.GetExecutingAssembly(),
                        "Myproject.Localization.Source"
                        )
                    )
                );

            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Authorization.Providers.Add<MyprojectAuthorizationProvider>();

            Configuration.Settings.Providers.Add<AppSettingProvider>();
            Configuration.Settings.Providers.Add<MyEmailSettingProvider>();
            Configuration.ReplaceService<ISmtpEmailSenderConfiguration, MySmtpEmailSenderConfiguration>(DependencyLifeStyle.Transient);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
