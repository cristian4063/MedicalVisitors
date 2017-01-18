//using Abp.Application.Navigation;
//using Abp.Localization;
//using MedicalVisitors.Authorization;

//namespace MedicalVisitors.Web
//{
//    /// <summary>
//    /// This class defines menus for the application.
//    /// It uses ABP's menu system.
//    /// When you add menu items here, they are automatically appear in angular application.
//    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
//    /// </summary>
//    public class MedicalVisitorsNavigationProvider : NavigationProvider
//    {
//        public override void SetNavigation(INavigationProviderContext context)
//        {
//            context.Manager.MainMenu
//                .AddItem(
//                    new MenuItemDefinition(
//                        "Home",
//                        new LocalizableString("HomePage", MedicalVisitorsConsts.LocalizationSourceName),
//                        url: "#/",
//                        icon: "fa fa-home"
//                        )
//                ).AddItem(
//                    new MenuItemDefinition(
//                        "Tenants",
//                        L("Tenants"),
//                        url: "#tenants",
//                        icon: "fa fa-globe",
//                        requiredPermissionName: PermissionNames.Pages_Tenants
//                        )
//                ).AddItem(
//                    new MenuItemDefinition(
//                        "Users",
//                        L("Users"),
//                        url: "#users",
//                        icon: "fa fa-users",
//                        requiredPermissionName: PermissionNames.Pages_Users
//                        )
//                ).AddItem(
//                    new MenuItemDefinition(
//                        "About",
//                        new LocalizableString("About", MedicalVisitorsConsts.LocalizationSourceName),
//                        url: "#/about",
//                        icon: "fa fa-info"
//                        )
//                );
//        }

//        private static ILocalizableString L(string name)
//        {
//            return new LocalizableString(name, MedicalVisitorsConsts.LocalizationSourceName);
//        }
//    }
//}

using Abp.Application.Navigation;
using Abp.Localization;

namespace MedicalVisitors.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class MedicalVisitorsNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("Inicio", MedicalVisitorsConsts.LocalizationSourceName),
                        url: "#/home",
                        icon: "glyphicon glyphicon-home"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Evaluations",
                        new LocalizableString("Evaluaciones", MedicalVisitorsConsts.LocalizationSourceName),
                        url: "#/evaluations",
                        icon: "glyphicon glyphicon-dashboard"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Reports",
                        new LocalizableString("Informes", MedicalVisitorsConsts.LocalizationSourceName),
                        url: "#/reports",
                        icon: "glyphicon glyphicon-stats"
                        ).AddItem(
                            new MenuItemDefinition(
                                "General Report",
                                new LocalizableString("Informe general", MedicalVisitorsConsts.LocalizationSourceName),
                                url: "#/reports/general",
                                icon: "glyphicon glyphicon-stats"
                                )
                        ).AddItem(
                            new MenuItemDefinition(
                                "Results Report",
                                new LocalizableString("Informe de resultados", MedicalVisitorsConsts.LocalizationSourceName),
                                url: "#/reports/results",
                                icon: "glyphicon glyphicon-stats"
                                )
                        ).AddItem(
                            new MenuItemDefinition(
                                "Needs Report",
                                new LocalizableString("Informe de necesidades", MedicalVisitorsConsts.LocalizationSourceName),
                                url: "#/reports/needs",
                                icon: "glyphicon glyphicon-stats"
                                )
                        )
                );
        }
    }
}
