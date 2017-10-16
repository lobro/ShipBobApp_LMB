//due to the simplicity of this application, I have decided to consolidate angularjs
//code into one site.js file. Ideally, upon increasing scope



var app = angular.module("userList",[]);
app.controller("userController",function($scope) {
    $scope.users = [{FirstName: "Laura", LastName: "Brennan", Id:1},
                    {FirstName: "Cari", LastName: "Brennan", Id:2}];

    $scope.ViewUserOrders=function(Id){
        alert(Id);

        window.location="#/Order?Id="+Id;
    }

    $scope.EditUser=function(Id){
        alert(Id);
        $location.path('/AddEditUser.cshtml');
        window.location='#/User/AddEditUser'
    }
}); 