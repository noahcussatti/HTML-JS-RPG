angular
  .module("rpgApp")
  .controller("gameController", function ($scope, $state, $stateParams, gameService) {

    gameService.getItems(function (response) {
      $scope.items = response
    })


    var _player = gameService.getPlayerById($stateParams.id);
    $scope.player = _player;

    // Getting players from DB
    gameService.getPlayers(function (response) {
      $scope.players = response
    })

    var _monster = gameService.getMonsterById($stateParams.id);
    $scope.monster = _monster;

    gameService.getMonsters(function (response) {
      $scope.monsters = response;
    })

    var _location = gameService.getLocationById($stateParams.id);
    $scope.location = _location;

    gameService.getLocations(function (response) {
      $scope.locations = response;
    })

    $scope.setLocation = function (id) {
      gameService.setLocation(id);
    }

    // === BATTLE FUNCTION === //
    $scope.monsterEncounter = function (id) {
      gameService.monsterEncounter(id);
      $scope.monsterAttackText = true;
      $scope.playerAttackText = true;
    }

    $scope.showMonster = true;
    var deadCheck = "not dead"

    $scope.monsterCheckDead = function (id) {
      deadCheck = gameService.monsterCheckDead(id)
      
        if (deadCheck == "dead") {
          $scope.showMonster = false;
        }
        else {
          $scope.showMonster = true;
        }
    }

    // === HEALING FUNCTION === //
    $scope.healPlayer = function(id) {
      gameService.healPlayer(id);
    }

    // === EQUIP FUNCTION === //
    $scope.equipItem = function(id) {
      gameService.equipItem(id)
    }

    $scope.animatedPouch = false;
    $scope.attackAnimation = false;

    // === RNG === //
    function getRandomInt(min, max) {
      return Math.floor(Math.random() * (max - min + 1)) + min;
    }

    // === LOOT FUNCTION === //
    $scope.lootItem = function(id) {
      gameService.lootItem(id)
    }
    $scope.showEquip = true;
    $scope.showHeal = true;
    $scope.showLoot1 = true;

    $scope.showPotion = true;

  })