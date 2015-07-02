'use strict';

/**
 * @ngdoc service
 * @name contactDirectory.contactService
 * @description
 * # contactService
 * Service in the contactDirectory.
 */
angular.module('uiApp')
  .service('ContactService', function (RestService, $http, appSettings) {
    this.result = [];
    var oThis = this;

    this.getFromService = function (callback) {
      RestService.query({ url: 'api/person'})
       .$promise.then(function (data) {

       //   var data = [{"Id":1,"name":"Daniel","lastname":"Restrepo ","telephoneNumber":"5892134   ","email":"danistiven19@gmail.com","city":1,"City1":null},{"Id":2,"name":"Camilo                                            ","lastname":"Gutierrez                                         ","telephoneNumber":"4848784   ","email":"cgutierexz@gmail.com                              ","city":1,"City1":null},{"Id":4,"name":"Isabel                                            ","lastname":"Gallego                                           ","telephoneNumber":"4884      ","email":"Gallego@hotmail.com                               ","city":1,"City1":null},{"Id":5,"name":"Daniela                                           ","lastname":"Restrepo                                          ","telephoneNumber":"5892134   ","email":"danistiven19@gmail.com                            ","city":1,"City1":null},{"Id":6,"name":"Daniela                                           ","lastname":"Restrepo                                          ","telephoneNumber":"5892134   ","email":"danistiven19@gmail.com                            ","city":1,"City1":null}];
        oThis.result = data;
          callback();
        }, function (err) {
          return  "Error";
        });
    };
  });
