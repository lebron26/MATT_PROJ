app.controller('homeCtrl', function homeCtrl ($scope,$anchorScroll,$timeout, $location, $http ) {

  $scope.category=["houseNlot","Popup","villas","condo"]


  $http.get('data/housenlot.json').success(function(data){
        $scope.houseNLot=data;
  })

  $http.get('data/popup.json').success(function(pop){
        $scope.Popup=pop;
  })
    //  console.log(angular.toJson($scope.houseNLot))
  $scope.submitFilter= function(searchText)
  {
    var param1='';
      if($scope.searchText==undefined)
      {
        console.log('true');
      }
      else if($scope.searchText == "Alcove" || $scope.searchText == "alcove" )
      {
         param1=0;
        $location.path('/item/'+param1);
      }
      else if($scope.searchText == "Spaces" || $scope.searchText == "spaces")
      {
        param1=1;
        $location.path('/item/'+param1);
      }
      else if($scope.searchText == "Nest" || $scope.searchText == "nest")
      {
        param1=2;
        $location.path('/item/'+param1);
      }
      else if($scope.searchText == "Cocoon" || $scope.searchText == "cocoon")
      {
        param1=3;
        $location.path('/item/'+param1);
      }
      else
      {
          console.log('Labas ka')

      }

  }

  $scope.gotoTOP = function ()
      {
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
