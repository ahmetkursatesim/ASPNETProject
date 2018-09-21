using Abp.Application.Navigation;
using Abp.Localization;
using Myproject.Authorization;

namespace Myproject.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See Views/Layout/_TopMenu.cshtml file to know how to render menu.
    /// </summary>
    public class MyprojectNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "home",
                        requiresAuthentication: true
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Tenants,
                        L("Tenants"),
                        url: "Tenants",
                        icon: "business",
                        requiredPermissionName: PermissionNames.Pages_Tenants
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Users,
                        L("Users"),
                        url: "Users",
                        icon: "people",
                        requiredPermissionName: PermissionNames.Pages_Users
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Roles,
                        L("Roles"),
                        url: "Roles",
                        icon: "local_offer",
                        requiredPermissionName: PermissionNames.Pages_Roles
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.UserOperation,
                        L("UserPhoto"),
                        url: "UserPhoto"


                    )
                )
               .AddItem(
                    new MenuItemDefinition(
                        "MultiLevelMenu",
                        L("Library"),
                        icon: "menu"
                    ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Author,
                        L("Author"),
                        url: "Author"
                        

                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Book,
                        L("Book"),
                        url: "Book"
                       

                    )
                )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, MyprojectConsts.LocalizationSourceName);
        }
    }
}
