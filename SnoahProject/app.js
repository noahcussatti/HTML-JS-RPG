var app = angular.module("rpgApp", ["ui.router"])

app.config(function ($stateProvider, $urlRouterProvider) {

  $urlRouterProvider.otherwise("/");

  $stateProvider
    .state("start", {
      url: "/",
      templateUrl: "./views/start.html",
      controller: "gameController"
    })
    .state("forest2", {
      url: "/forest2",
      templateUrl: "./views/forest2.html",
      controller: "gameController"
    })
    .state("forest3", {
      url: "/forest3",
      templateUrl: "./views/forest3.html",
      controller: "gameController"
    })
    .state("forest4", {
      url: "/forest4",
      templateUrl: "./views/forest4.html",
      controller: "gameController"
    })
    .state("forest4ToMountain", {
      url: "/forest4ToMountain",
      templateUrl: "./views/forest4ToMountain.html",
      controller: "gameController"
    })
    .state("mountain1", {
      url: "/mountain1",
      templateUrl: "./views/mountain1.html",
      controller: "gameController"
    })
    .state("mountain2", {
      url: "/mountain2",
      templateUrl: "./views/mountain2.html",
      controller: "gameController"
    })
    .state("mountain3", {
      url: "/mountain3",
      templateUrl: "./views/mountain3.html",
      controller: "gameController"
    })
    .state("mountain3Snow", {
      url: "/mountain3Snow",
      templateUrl: "./views/mountain3Snow.html",
      controller: "gameController"
    })
    .state("snow1", {
      url: "/snow1",
      templateUrl: "./views/snow1.html",
      controller: "gameController"
    })
    .state("snow2", {
      url: "/snow2",
      templateUrl: "./views/snow2.html",
      controller: "gameController"
    })
    .state("snow3", {
      url: "/snow3",
      templateUrl: "./views/snow3.html",
      controller: "gameController"
    })
    .state("snow4", {
      url: "/snow4",
      templateUrl: "./views/snow4.html",
      controller: "gameController"
    })
    .state("snow5", {
      url: "/snow5",
      templateUrl: "./views/snow5.html",
      controller: "gameController"
    })
    .state("rockypath1", {
      url: "/rockypath1",
      templateUrl: "./views/rockypath1.html",
      controller: "gameController"
    })
    .state("rockypath2", {
      url: "/rockypath2",
      templateUrl: "./views/rockypath2.html",
      controller: "gameController"
    })
    .state("volcano1", {
      url: "/volcano1",
      templateUrl: "./views/volcano1.html",
      controller: "gameController"
    })
    .state("volcano2", {
      url: "/volcano2",
      templateUrl: "./views/volcano2.html",
      controller: "gameController"
    })
    .state("volcano3", {
      url: "/volcano3",
      templateUrl: "./views/volcano3.html",
      controller: "gameController"
    })
    .state("volcano4", {
      url: "/volcano4",
      templateUrl: "./views/volcano4.html",
      controller: "gameController"
    })
    .state("volcano5", {
      url: "/volcano5",
      templateUrl: "./views/volcano5.html",
      controller: "gameController"
    })
    .state("castle1", {
      url: "/castle1",
      templateUrl: "./views/castle1.html",
      controller: "gameController"
    })
    .state("castle2", {
      url: "/castle2",
      templateUrl: "./views/castle2.html",
      controller: "gameController"
    })
    .state("castle3", {
      url: "/castle3",
      templateUrl: "./views/castle3.html",
      controller: "gameController"
    })
    .state("castle4", {
      url: "/castle4",
      templateUrl: "./views/castle4.html",
      controller: "gameController"
    })
    .state("castleHR1", {
      url: "/castleHR1",
      templateUrl: "./views/castleHR1.html",
      controller: "gameController"
    })
    .state("castleHR2", {
      url: "/castleHR2",
      templateUrl: "./views/castleHR2.html",
      controller: "gameController"
    })
    .state("desert1", {
      url: "/desert1",
      templateUrl: "./views/desert1.html",
      controller: "gameController"
    })
    .state("desert2", {
      url: "/desert2",
      templateUrl: "./views/desert2.html",
      controller: "gameController"
    })
    .state("desert3", {
      url: "/desert3",
      templateUrl: "./views/desert3.html",
      controller: "gameController"
    })
    .state("desert3c1", {
      url: "/desert3c1",
      templateUrl: "./views/desert3c1.html",
      controller: "gameController"
    })
    .state("desert3c2", {
      url: "/desert3c2",
      templateUrl: "./views/desert3c2.html",
      controller: "gameController"
    })
    .state("desert4", {
      url: "/desert4",
      templateUrl: "./views/desert4.html",
      controller: "gameController"
    })
    .state("desert5", {
      url: "/desert5",
      templateUrl: "./views/desert5.html",
      controller: "gameController"
    })
    .state("oasis2", {
      url: "/oasis2",
      templateUrl: "./views/oasis2.html",
      controller: "gameController"
    })
    .state("oasis3", {
      url: "/oasis3",
      templateUrl: "./views/oasis3.html",
      controller: "gameController"
    })
    .state("oasis4", {
      url: "/oasis4",
      templateUrl: "./views/oasis4.html",
      controller: "gameController"
    })
    .state("ruins1", {
      url: "/ruins1",
      templateUrl: "./views/ruins1.html",
      controller: "gameController"
    })
    .state("ruins2", {
      url: "/ruins2",
      templateUrl: "./views/ruins2.html",
      controller: "gameController"
    })
    .state("ruins2L", {
      url: "/ruins2L",
      templateUrl: "./views/ruins2L.html",
      controller: "gameController"
    })
    .state("ruins2R", {
      url: "/ruins2R",
      templateUrl: "./views/ruins2R.html",
      controller: "gameController"
    })
    .state("ruins3L", {
      url: "/ruins3L",
      templateUrl: "./views/ruins3L.html",
      controller: "gameController"
    })
    .state("cave1", {
      url: "/cave1",
      templateUrl: "./views/cave1.html",
      controller: "gameController"
    })
    .state("cave2", {
      url: "/cave2",
      templateUrl: "./views/cave2.html",
      controller: "gameController"
    })
    .state("cloudcity1", {
      url: "/cloudcity1",
      templateUrl: "./views/cloudcity1.html",
      controller: "gameController"
    })
    .state("cloudcity2", {
      url: "/cloudcity2",
      templateUrl: "./views/cloudcity2.html",
      controller: "gameController"
    })
    .state("gameOver", {
      url: "/gameover",
      templateUrl: "./views/gameOver.html",
      controller: "gameController"
    })
})
