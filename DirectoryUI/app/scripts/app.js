'use strict';

(function (env) {
  window.getUrlService = function () {
      return 'http://localhost:50714/';
  }
})('DEV');

/**
 * @ngdoc overview
 * @name uiApp
 * @description
 * # uiApp
 *
 * Main module of the application.
 */
angular
  .module('uiApp', [
    'ngResource',
    'ngRoute',
    'smart-table',
    'restService',
    'ui.router'
  ])
  .config(['$stateProvider', '$urlRouterProvider', '$httpProvider' ,function ($stateProvider, $urlRouterProvider, $httpProvider) {
    $httpProvider.defaults.useXDomain = true;
    delete $httpProvider.defaults.headers.common['X-Requested-With'];

    $urlRouterProvider.otherwise("main");

    $stateProvider
      .state('main', {
        url: "/main",
        templateUrl: "views/main.html",
        controller: 'MainCtrl'
      })
      .state('contact', {
        url: "/contact",
        templateUrl: "views/contact/list.html",
        controller: 'ContactCtrl'
      });
  }]).constant('appSettings', {
    apiServiceBaseUri: getUrlService()
  });
