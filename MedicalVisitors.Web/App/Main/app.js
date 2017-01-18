(function () {
    'use strict';
    
    var app = angular.module('app', [
        'ngAnimate',
        'ngSanitize',

        'ui.router',
        'ui.bootstrap',
        'ui.jq',

        'abp',

        'angularUtils.directives.uiBreadcrumbs'
    ]);

    //Configuration for Angular UI routing.
    app.config([
        '$stateProvider', '$urlRouterProvider',
        function($stateProvider, $urlRouterProvider) {
            $urlRouterProvider.otherwise('/');

            //if (abp.auth.hasPermission('Pages.Users')) {
            //    $stateProvider
            //        .state('users', {
            //            url: '/users',
            //            templateUrl: '/App/Main/views/users/index.cshtml',
            //            menu: 'Users' //Matches to name of 'Users' menu in MedicalVisitorsNavigationProvider
            //        });
            //    $urlRouterProvider.otherwise('/users');
            //}

            //if (abp.auth.hasPermission('Pages.Tenants')) {
            //    $stateProvider
            //        .state('tenants', {
            //            url: '/tenants',
            //            templateUrl: '/App/Main/views/tenants/index.cshtml',
            //            menu: 'Tenants' //Matches to name of 'Tenants' menu in MedicalVisitorsNavigationProvider
            //        });
            //    $urlRouterProvider.otherwise('/tenants');
            //}

            $stateProvider
                .state('home', {
                    url: '/',
                    templateUrl: '/App/Main/views/home/home.cshtml',
                    menu: 'Home' //Matches to name of 'Home' menu in MedicalVisitorsNavigationProvider
                })
                .state('evaluations', {
                    url: '/evaluations',
                    templateUrl: '/App/Main/views/evaluations/evaluations.cshtml',
                    menu: 'Evaluations', //Matches to name of 'Evaluations' menu in MedicalVisitorsNavigationProvider
                    data: {
                        displayName: 'Evaluaciones'
                    }
                })
				.state('createEvaluation', {
				    url: '/evaluations/createEvaluation',
				    templateUrl: '/App/Main/views/evaluations/createEvaluation.cshtml',
				    menu: 'createEvaluation', //Matches to name of 'Evaluations' menu in MedicalVisitorsNavigationProvider
				    data: {
				        displayName: 'Crear Evaluación'
				    }
				})
                .state('reports', {
                    url: '/reports',
                    templateUrl: '/App/Main/views/reports/reports.cshtml',
                    menu: 'Reports', //Matches to name of 'Reports' menu in MedicalVisitorsNavigationProvider
                    data: {
                        displayName: 'Reportes'
                    }
                })
                .state('general report', {
                    url: '/reports/general',
                    templateUrl: '/App/Main/views/reports/generalReport.cshtml',
                    menu: 'General Report', //Matches to name of 'General Report' menu in MedicalVisitorsNavigationProvider
                    data: {
                        displayName: 'Informe General'
                    }
                })
                .state('results report', {
                    url: '/reports/results',
                    templateUrl: '/App/Main/views/reports/resultsReport.cshtml',
                    menu: 'Results Report', //Matches to name of 'Results Report' menu in MedicalVisitorsNavigationProvider
                    data: {
                        displayName: 'Informe Resultados'
                    }
                })
                .state('needs report', {
                    url: '/reports/needs',
                    templateUrl: '/App/Main/views/reports/needsReport.cshtml',
                    menu: 'Needs Report', //Matches to name of 'Needs Report' menu in MedicalVisitorsNavigationProvider
                    data: {
                        displayName: 'Informe Necesidades'
                    }
                })
                .state('about', {
                    url: '/about',
                    templateUrl: '/App/Main/views/about/about.cshtml',
                    menu: 'About' //Matches to name of 'About' menu in MedicalVisitorsNavigationProvider
                });
        }
    ]);
})();