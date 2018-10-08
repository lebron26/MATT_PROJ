app.controller('ProductController', ['$scope', '$routeParams', function($scope, $routeParams){
  $scope.detail = $routeParams.id;
}])
