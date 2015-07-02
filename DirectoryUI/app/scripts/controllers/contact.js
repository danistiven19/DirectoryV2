'use strict';

/**
 * @ngdoc function
 * @name uiApp.controller:ContactCtrl
 * @description
 * # ContactCtrl
 * Controller of the uiApp
 */
angular.module('uiApp')
  .controller('ContactCtrl', function ($scope, ContactService) {

    $scope.itemsByPage=2;

    var init = function(){
      ContactService.getFromService(showList);
    };

    var showList = function(){
      $scope.data = ContactService.result;
    };

    $scope.removeRow = function removeRow(row) {
      var index = $scope.data.indexOf(row);
      if (index !== -1) {
        $scope.data.splice(index, 1);
      }
    };

    init();
  });
