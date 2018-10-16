app.controller('homeCtrl', function homeCtrl($scope, $anchorScroll, $timeout, $location, $http) {

  $scope.category = ["houseNlot", "Popup", "villas", "condo"]

  $http.get('data/revoFlavor.json').success(function(data) {
    $scope.houseNLot = data;

    $scope.house = [];
    angular.forEach($scope.houseNLot, function(order) {
      angular.forEach(order.housenlot, function(bahay) {
        $scope.house.push(bahay);
      })
    })
    $scope.Popup = [];
    angular.forEach($scope.houseNLot, function(order) {
      angular.forEach(order.popups, function(pop) {
        $scope.Popup.push(pop);
      })
    })

    $scope.testing = function() {
      var gethouse = $scope.searchText;
      var getproperty;

      angular.forEach($scope.houseNLot, function(value, key) {

        for (var desc in value) {
          angular.forEach(value[desc], function(v, k) {
            getproperty = v.name;
            getvalue = v.id
            if (gethouse.toUpperCase() == getproperty.toUpperCase()) {
              if (getvalue < 4)
                $location.path('/item/' + getvalue);
              else {
                $location.path('/pop');
              }
            }

          })
        }
      })
    }
  })

  $http.get('data/filterlist.json').success(function(filter) {
    $scope.housefilter = filter;
    $scope.complete = function(string) {
      $scope.hidethis = false;
      var output = [];

      angular.forEach($scope.housefilter, function(category) {

        if (category.toLowerCase().indexOf(string.toLowerCase()) >= 0) {
          output.push(category);
        }
      })
      $scope.filterhouse = output;

    }

    $scope.fillTextbox = function(string) {
      $scope.searchText = string;
      $scope.hidethis = true;
    }


  });


  //  console.log($scope.house);

  //  console.log(angular.toJson($scope.houseNLot))
  $scope.submitFilter = function(searchText) {
    var param1 = '';
    if ($scope.searchText == undefined) {
      console.log('true');
    } else if ($scope.searchText == "Alcove" || $scope.searchText == "alcove") {
      param1 = 0;
      $location.path('/item/' + param1);
    } else if ($scope.searchText == "Spaces" || $scope.searchText == "spaces") {
      param1 = 1;
      $location.path('/item/' + param1);
    } else if ($scope.searchText == "Nest" || $scope.searchText == "nest") {
      param1 = 2;
      $location.path('/item/' + param1);
    } else if ($scope.searchText == "Cocoon" || $scope.searchText == "cocoon") {
      param1 = 3;
      $location.path('/item/' + param1);
    } else {
      console.log('Labas ka')

    }

  }

  $scope.gotoTOP = function() {
      $location.hash("navbar");
      $anchorScroll();
    }

  $scope.gotoAnchor = function(x) {
    var newHash = x;
    if ($location.hash() !== newHash) {
      // set the $location.hash to `newHash` and
      // $anchorScroll will automatically scroll to it
      $location.hash(x);
    } else {
      // call $anchorScroll() explicitly,
      // since $location.hash hasn't changed
      $anchorScroll();
    }
  };
})
