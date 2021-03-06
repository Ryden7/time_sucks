﻿var app = angular.module('time', ['ngRoute']); //Sets up the Angular app, and includes the ngRoute module

app.config(function ($routeProvider) {
    $routeProvider //Assigns the template file and controller for the routes
        .when("/", {
            templateUrl: "templates/login.html",
            controller: "LoginCtrl"
        })
        .when("/login", {
            templateUrl: "templates/login.html",
            controller: "LoginCtrl"
        })
        .when("/register", {
            templateUrl: "templates/register.html",
            controller: "RegisterCtrl"
        })
        .when("/dashboard", {
            templateUrl: "templates/dashboard.html",
            controller: "DashboardCtrl"
        })
        .when("/courses", {
            templateUrl: "templates/courses.html",
            controller: "CoursesCtrl"
        })
        .when("/course/:ID", {
            templateUrl: "templates/course.html",
            controller: "CourseCtrl"
        })
        .when("/project/:ID", {
            templateUrl: "templates/project.html",
            controller: "ProjectCtrl"
        })
        .when("/group/:ID", {
            templateUrl: "templates/group.html",
            controller: "GroupCtrl"
        })
        .when("/users", {
            templateUrl: "templates/users.html",
            controller: "UsersCtrl"
        })
        .when("/user/:ID", {
            templateUrl: "templates/user.html",
            controller: "UserCtrl"
        });
});