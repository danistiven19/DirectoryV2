'use strict';
angular.module('restService', ['ngResource'])
  .factory('RestService', ['$resource', 'appSettings', function ($resource, appSettings) {
    return $resource(appSettings.apiServiceBaseUri + ':url/:id', {url: '@url'},
      {
        show: {method: 'GET', params: {id: '@id'}},
        showArrayById: {method: 'GET', params: {id: '@id'}, isArray: true},
        query: {method: 'GET', isArray: true},
        create: {method: 'POST'},
        postArr: {method: 'POST', isArray: true},
        update: {method: 'PUT', params: {id: '@id'}},
        remove: {method: 'DELETE', params: {id: '@id'}}
      });
  }]);
