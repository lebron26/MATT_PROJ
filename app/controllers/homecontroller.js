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

  //  console.log(angular.toJson($scope.houseNLot))
  /*
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

  }*/

  //paragraphs
  $scope.read = "READ MORE";

  $scope.para1 = "Revolution Flavorscapes at Lakeshore, situated in the Culinary Capital of the Philippines, is considered the World’s First Livable Food Park, as the project will house pop-up stores featuring various cuisines from different countries. It is developed by Revolution Precrafted in collaboration with Central Country Estate Inc.The Lakeshore is the first master-planned community in the country to offer residents a world of secluded lakeside luxury, 250 hectares of prime land crowned with a magnificent 12 hectare man-made lake.";

  $scope.para2 = "Residents need not go far to enjoy adventure-filled activities like fishing, sailing and kayaking. ​With an enchanting 12-hectare man-made lake as its main feature, The Lakeshore offers a beautiful and serene ambiance complimented with recreational and commercial facilities for the whole family to enjoy. The Lakeshore features a wide variety of water sports facilities such as non-motorized boating, kayaking and sailing. A white water jet fountain shooting up to 18 meteres high will serve as a landmark and act as a filtering and aeration device.The island in the lake even enhances the splendor of this haven with an enchanting 12 - hectare man - made lake as its main feature,  The Lakeshore offers a beautiful and serene ambiance complimented with recreational and commercial facilities for the whole family to enjoy.The Lakeshore features a wide variety of water sports facilities such as non - motorized boating, kayaking and sailing.A white water jet fountain shooting upto 18 meteres high will serve as a landmark and act as a filtering and aeration device.The island in the lake even enhances the splendor of this haven.";
  $scope.numLimit = 150;
  $scope.readMore = function() {

    if ($scope.numLimit == 10000) {
      $scope.read = "READ MORE";
      $scope.numLimit = 150;
    } else {
      $scope.numLimit = 10000;
      $scope.read = "READ LESS";
    }
  };

  $scope.gotoTOP = function() {
      $timeout(function() {
    $location.hash('navbar');
    $anchorScroll();
  });


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
  }
})
