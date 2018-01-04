/// <reference path="../../scripts/knockout-3.4.2.js" />

var User = function (id, name, roleId, genderId) {
    var self = this;

    self.id = ko.observable(id);
    self.name = ko.observable(name);
    self.roleId = ko.observable(roleId);

    self.genderId = ko.observable(genderId);

    self.role = ko.pureComputed(function () {
        switch (self.roleId()) {
            case 2:
                return "Admin";
            case 3:
                return "Worker";
            case 4:
                return "Guest";
            default:
                return "Unknown";
        }
    });

    self.gender = ko.pureComputed(function () {
        switch (self.genderId()) {
            case 2:
                return "Male";
            case 3:
                return "Female";
            default:
                return "Unknown";
        }
    });
};

var Role = function (id, name) {
    var self = this;

    self.id = ko.observable(id);
    self.name = ko.observable(name);
};


var Gender = function (id, name) {
    var self = this;

    self.id = ko.observable(id);
    self.name = ko.observable(name);
};