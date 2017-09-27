angular
  .module("rpgApp")
  .service("gameService", function ($http, $state) {

    // Player variables
    var _players = [];
    var _playerId = 1;
    // Array of all items
    var _items = [];
    // Array of player's current items
    var _playerItems = [];
    // Monsters
    var _monsters = [];
    // Locations
    var _locations = [];

    // Player Constructor
    function Player(id, name, maxHealth, currentHealth, power, backpack, currentLocation, currentHelmet, currentChest, currentPants, currentWeapon) {
      this.id = id;
      this.name = name;
      this.maxHealth = maxHealth;
      this.currentHealth = currentHealth;
      this.power = power;
      this.backpack = backpack;
      this.currentLocation = currentLocation;
      this.currentHelmet = currentHelmet;
      this.currentChest = currentChest;
      this.currentPants = currentPants;
      this.currentWeapon = currentWeapon;
    }

    // Item constructor
    function Item(id, name, power, type) {
      this.id = id;
      this.name = name;
      this.power = power;
      this.type = type;
    }

    // Monster constructor
    function Monster(id, name, health, power, image, items) {
      this.id = id;
      this.name = name;
      this.health = health;
      this.power = power;
      this.image = image;
      this.items = items;
    }

    // Location constructor
    function Location(id, name, image, item) {
      this.id = id;
      this.name = name;
      this.image = image;
      this.item = item;
    }

    this.getItems = function (cb) {
      if (_items.length == 0) {
        $http.get("http://192.168.7.100:50680/api/Items")
          .success(function (response) {
            _items = response
            cb(_items)
          })
      }
    }

    // ========= PLAYERS ========= //
    // -=- GET PLAYERS FROM DB -=- //
    this.getPlayers = function (cb) {
      if (_players.length == 0) {
        $http.get("../db/players.json")
          .success(function (response) {
            _players = response
            cb(_players)
          })
          console.log(_players[0]);
      }
      else {
        cb(_players)
      }
    }
    // Get Players
    this.getPlayerById = function (id) {
      for (var i = 0; i < _players.length; i++) {
        if (_players[i].id == id) {
          return _players[i]
        }
      }
      console.log(_players[0])
    }

    // ========= MONSTERS ========= //
    // -=- GET MONSTERS FROM DB -=- //
    this.getMonsters = function (cb) {
      if (_monsters.length == 0) {
        $http.get("../db/monsters.json")
          .success(function (response) {
            _monsters = response
            cb(_monsters)
          })
      }
      else {
        cb(_monsters)
      }
    }
    // -=- GET MONSTERS -=- //
    this.getMonsterById = function (id) {
      for (var i = 0; i < _monsters.length; i++) {
        if (_monsters[i].id == id) {
          return _monsters[i]
        }
      }
    }

    // ========= LOCATIONS ========= //
    // -=- GET LOCATIONS FROM DB -=- //
    this.getLocations = function (cb) {
      if (_locations.length == 0) {
        $http.get("../db/locations.json")
          .success(function (response) {
            _locations = response
            cb(_locations)
          })
      }
      else {
        cb(_locations)
      }
    }
    // -=- GET LOCATIONS -=- //
    this.getLocationById = function (id) {
      for (var i = 0; i <_locations.length; i++) {
        if (_locations[i].id == id) {
          return _locations[i]
        }
      }
    }

    // === SET LOCATION/MOVE FUNCTION === //
    this.setLocation = function (id) {
      for (var i = 0; i < _locations.length; i++) {
        if (_locations[i].id == id) {
          console.log("test")
          _players[0].currentLocation[0].id = _locations[i].id;
          _players[0].currentLocation[0].name = _locations[i].name;
          _players[0].currentLocation[0].image = _locations[i].image;
          console.log(_players[0])
        }
      }
    }
  
    // === HEALING ITEM FUNCTION === //
    this.healPlayer = function (id) {
      // Checks to see if the item is a healing item
      console.log(_players[0].currentHealth)
      if(_players[0].backpack[id].type == "heal") {
        // Adds item power to player's current health
        _players[0].currentHealth += _players[0].backpack[id].power;
        // Checks to see if current health is above max health
        if (_players[0].currentHealth > _players[0].maxHealth) {
          // if so, changes current health to max health
          _players[0].currentHealth = _players[0].maxHealth;
        }
        console.log(_players[0].currentHealth);
        _players[0].backpack.splice(id, 1);
        // -=- REMOVE ITEM FROM BACKPACK *NEED TO ADD* -=-
      }
    }

    // === EQUIP ITEM FUNCTION === //
    this.equipItem = function (id) {

      // -=- EQUIP HELMET -=- //
      if(_players[0].backpack[id].type == "helmet") {
        // Remove current helm power from max health
        _players[0].maxHealth -= _players[0].currentHelmet.power;
        // Add Helmet to currentHelmet
        _players[0].currentHelmet.id = _players[0].backpack[id].id;
        _players[0].currentHelmet.name = _players[0].backpack[id].name;
        _players[0].currentHelmet.power = _players[0].backpack[id].power;
        _players[0].currentHelmet.type = _players[0].backpack[id].type;
        // Add current helm power to max health
        _players[0].maxHealth += _players[0].currentHelmet.power;
      }

      // -=- EQUIP CHEST PIECE -=- //
      else if (_players[0].backpack[id].type == "chest") {
        // Remove current chest power from max health
        _players[0].maxHealth -= _players[0].currentChest.power;
        // Add Chest to currentChest
        _players[0].currentChest.id = _players[0].backpack[id].id;
        _players[0].currentChest.name = _players[0].backpack[id].name;
        _players[0].currentChest.power = _players[0].backpack[id].power;
        _players[0].currentChest.type = _players[0].backpack[id].type;
        // Add current helm power to max health
        _players[0].maxHealth += _players[0].currentChest.power;
      }

      // -=- EQUIP WRIST -=- //
      else if (_players[0].backpack[id].type == "wrist") {
        // Remove current helm power from max health
        _players[0].maxHealth -= _players[0].currentWrist.power;
        // Add Wrist to currentWrist
        _players[0].currentWrist.id = _players[0].backpack[id].id;
        _players[0].currentWrist.name = _players[0].backpack[id].name;
        _players[0].currentWrist.power = _players[0].backpack[id].power;
        _players[0].currentWrist.type = _players[0].backpack[id].type;
        // Add current helm power to max health
        _players[0].maxHealth += _players[0].currentWrist.power;
      }

      // -=- EQUIP WEAPON -=- //
      else if (_players[0].backpack[id].type == "weapon") {
        // Remove current weapon power from player power
        _players[0].power -= _players[0].currentWeapon.power;
        // Add Weapon to currentWeapon
        _players[0].currentWeapon.id = _players[0].backpack[id].id;
        _players[0].currentWeapon.name = _players[0].backpack[id].name;
        _players[0].currentWeapon.power = _players[0].backpack[id].power;
        _players[0].currentWeapon.type = _players[0].backpack[id].type;
        // Add current weapon power to player power
        _players[0].power += _players[0].currentWeapon.power;
        console.log(_players[0])
      }
    }

    // === RNG FUNCTION === //
    function getRandomInt(min, max) {
      return Math.floor(Math.random() * (max - min + 1)) + min;
    }

    // === BATTLE FUNCTION === //
    this.monsterEncounter = function(monsterId) {
      
        if (_monsters[monsterId].health > 0) {
          // -=- GENERATE PLAYER AND MONSTER ATTACK -=- //
          var playerAttack = getRandomInt((_players[0].power / 2), _players[0].power);
          var monsterAttack = getRandomInt((_monsters[monsterId].power / 2), _monsters[monsterId].power);
          _monsters[monsterId].health -= playerAttack;
          _players[0].currentHealth -= monsterAttack;

          var str2 = (_monsters[monsterId].name + " attacked you for " + monsterAttack + " damage!")
          var str3 = ("You attacked the " + _monsters[monsterId].name + " for " + playerAttack + " damage!");
          var str4 = (_monsters[monsterId].name + "'s Health: " + _monsters[monsterId].health)

          document.getElementById("battleText2").innerHTML = str2
          document.getElementById("battleText3").innerHTML = str3
          document.getElementById("battleText4").innerHTML = str4

          if (_players[0].currentHealth <= 0) {
            $state.go("gameOver");
            _players[0].currentLocation[0].id = _locations[0].id;
            _players[0].currentLocation[0].name = _locations[0].name;
            _players[0].currentLocation[0].image = _locations[0].image;
            _players[0].currentHealth = _players[0].maxHealth;
            document.getElementById("gameOver").innerHTML = "GAME OVER";
          }
          else if (_monsters[monsterId].health <= 0) {
            // -=- Get Chances to drop items -=- //
            var helmChance = getRandomInt(1, 2);
            var chestChance = getRandomInt(1, 3);
            var weaponChance = getRandomInt(1, 2);

            // If monster has helmet
            if (_monsters[monsterId].currentHelmet != null || _monsters[monsterId].currentHelmet != undefined) {
              if (helmChance == 1) {
                _players[0].backpack.push(_monsters[monsterId].currentHelmet);
              }
            }
            
            // If monster has a chestplate
            if (_monsters[monsterId].currentChest != null || _monsters[monsterId].currentCghest != undefined) {
              if (chestChance == 1) {
              _players[0].backpack.push(_monsters[monsterId].currentChest);
              }
            }
          
            // If monster has Weapon
            if (_monsters[monsterId].currentWeapon != null || _monsters[monsterId].currentWeapon != undefined) {
              if (weaponChance == 1) {
              _players[0].backpack.push(_monsters[monsterId].currentWeapon);
            }
            }
            
          }
        }
      }

      // Checks to see if monster is dead
      this.monsterCheckDead = function (monsterId) {
        if (_monsters[monsterId].health <= 0) {
          return "dead";
        }
        else {
          return "not dead";
        }
      }

      var lootedItem;
      this.lootItem = function (itemId) {
        lootedItem = _items[itemId]
        _players[0].backpack.push(lootedItem)
        console.log(_players[0])
      }
      
  })