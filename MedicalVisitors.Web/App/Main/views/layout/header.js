(function () {
    var controllerId = 'app.views.layout.header';
    angular.module('app').controller(controllerId, [
        '$rootScope', '$state', 'appSession', '$window',
        function ($rootScope, $state, appSession, $window) {
            var vm = this;

            vm.languages = abp.localization.languages;
            vm.currentLanguage = abp.localization.currentLanguage;

            vm.menu = abp.nav.menus.MainMenu;
            vm.currentMenuName = $state.current.menu;

            $rootScope.$on('$stateChangeSuccess', function (event, toState, toParams, fromState, fromParams) {
                vm.currentMenuName = toState.menu;
            });

            vm.getShownUserName = function () {
                if (!abp.multiTenancy.isEnabled) {
                    return appSession.user.userName;
                } else {
                    if (appSession.tenant) {
                        return appSession.tenant.tenancyName + '\\' + appSession.user.userName;
                    } else {
                        return '.\\' + appSession.user.userName;
                    }
                }
            };

            abp.event.on('abp.notifications.received', function (userNotification) {
                abp.notifications.showUiNotifyForUserNotification(userNotification);
            });

            //New
            vm.clickMenu = function () {
                $(".sidebar-menu li").removeClass("open");
            }

            vm.clickSubMenu = function (index) {
                var item = $("#" + index);
                if (item.hasClass('open')) {
                    item.removeClass('open');
                } else {
                    item.addClass('open');
                }
            }

            $("#bootbox-confirm").off().on('click', function () {
                bootbox.confirm({
                    size: "small",
                    message: "Está seguro que desea salir del sistema??",
                    buttons: {
                        confirm: {
                            label: 'Si',
                            className: 'btn btn-primary'
                        },
                        cancel: {
                            label: 'No',
                            className: 'btn btn-default'
                        }
                    },
                    callback: function (result) {
                        if (result) $window.location.href = '/Account/Logout';
                    }
                });
            });
        }
    ]);
})();