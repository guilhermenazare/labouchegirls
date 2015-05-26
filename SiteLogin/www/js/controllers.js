angular.module('starter.controllers', [])

.controller('DashCtrl', function($scope) {})

.controller('HomeCtrl', function($scope, $http) {
//  $scope.images = [];
// 
//    $scope.loadImages = function() {
//        for(var i = 0; i < 100; i++) {
//            $scope.images.push({id: i, src: "img/50x50.gif"});
//        }
//    };

$http.get('data/acompanhates.json').success (function(data){
				$scope.guitarVariable = data;
			}); 
})

.controller('ChatsCtrl', function($scope, Chats) {
  $scope.chats = Chats.all();
  $scope.remove = function(chat) {
    Chats.remove(chat);
  };
})

.controller('ChatDetailCtrl', function($scope, $stateParams, Chats) {
  $scope.chat = Chats.get($stateParams.chatId);
})

.controller('AccountCtrl', function($scope) {
  $scope.settings = {
    enableFriends: true
  };
})

.controller('LoginCtrl', function($scope, LoginService, $ionicPopup, $state) {
    $scope.data = {};
 
    $scope.login = function() {
        LoginService.loginUser($scope.data.username, $scope.data.password).success(function(data) {
            $state.go('tab.dash');
        }).error(function(data) {
            var alertPopup = $ionicPopup.alert({
                title: 'Login falhou!',
                template: 'Por favor informar as credências corretas!'
            });
        });
    };
});
