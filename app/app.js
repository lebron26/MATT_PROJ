var app = angular.module('myApp', ['ngRoute']);


app.config(function ($routeProvider, $locationProvider){
  $routeProvider
        .when('/',{
          controller: 'homeCtrl',
          templateUrl: 'template/home.html'
        })
        .when('/about-us',{
          controller: 'homeCtrl',
          templateUrl: 'template/about-us.html'
        })


        .when('/home',{
          controller: 'homeCtrl',
          templateUrl: 'template/home.html'
        })
        .when('/home2',{
          controller: 'homeCtrl',
          templateUrl: 'template/home2.html'
        })
        .when('/properties',{
          controller: 'homeCtrl',
          templateUrl: 'template/properties.html'
        })
        .when('/house',{
          controller: 'homeCtrl',
          templateUrl: 'template/model/house.html'
        })
        .when('/pop',{
          controller: 'homeCtrl',
          templateUrl: 'template/model/pop.html'
        })
        .when('/villas',{
          controller: 'homeCtrl',
          templateUrl: 'template/404.html'
        })
        .when('/condo',{
          controller: 'homeCtrl',
          templateUrl: 'template/404.html'
        })

        .when('/item/:id',{
          controller: 'ProductController',
          templateUrl: 'template/item-detail.html'
        })

        .when('/contact',{
          controller: 'homeCtrl',
          templateUrl: 'template/contact-us.html'
        })

        .when('/error',{
          controller: 'homeCtrl',
          templateUrl: 'template/404.html'
        })

        .otherwise({
          redirectTo: "/"
        });
})


app.service('search',function($location){
  this.getSearch=function(){
    if(searchText=='home')
    $location.path('#/home');
  }
})

app.filter('searchFor', function(){

	// All filters must return a function. The first parameter
	// is the data that is to be filtered, and the second is an
	// argument that may be passed with a colon (searchFor:searchString)

	return function(arr, searchBox){

		if(!searchBox){
			return arr;
		}

		var result = [];

		searchBox = searchBox.toLowerCase();

		// Using the forEach helper method to loop through the array
		angular.forEach(arr, function(item){

			if(item.name.toLowerCase().indexOf(searchBox) !== -1){
				result.push(item);
			}

		});

		return result;
	};

});
