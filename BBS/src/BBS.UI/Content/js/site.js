/// <reference path="models.js" />
/// <reference path="../../scripts/jquery-3.2.1.js" />

//var serviceRoot = 'http://localhost:1300';
var serviceRoot = 'https://localhost:1301';

var AppViewModel = function () {
    var self = this;

    self.users = ko.observableArray([]);
    self.roles = ko.observableArray([]);
    self.genders = ko.observableArray([]);

    self.currentUser = ko.observable(new User());

    self.getUsers = function () {
        // Get request from service and parse to the table
        $.getJSON(serviceRoot + '/api/users', function (data) {
            var mappedUsers = $.map(data, function (item) {
                return new User(item.id, item.name, item.roleId, item.genderId);
            });
            self.users(mappedUsers);
        });
    };
    self.getUsers();

    // Save or update the user - Upsert
    self.saveUser = function () {
        self.currentUser().genderId(self.genderChecked());
        var user = {
            id: self.currentUser().id(),
            Name: self.currentUser().name(),
            GenderId: self.currentUser().genderId(),
            RoleId: self.currentUser().roleId()
        };
        console.log(user);

        // Create request to service
        $.post(serviceRoot + '/api/users', user,
            function () {
                self.getUsers();
            }).fail(function (xhr, status, error) {
                self.getUsers();
                alert("error while saving data to db" + error);
            });

        // reset user
        self.currentUser(new User());
        self.genderChecked("1");
    }

    self.modifyUser = function (user) {
        // user will automatically be the one the user clicked on

        // It's smell I know. need to refactor this functionality
        if (user.genderId() === 1) {
            self.genderChecked("1");
            user.genderId(1);
        } else if (user.genderId() === 2) {
            self.genderChecked("2");
            user.genderId(2);
        } else if (user.genderId() === 3) {
            self.genderChecked("3");
            user.genderId(3);
        } else {
            self.genderChecked();
        }

        self.currentUser(user);
    }

    // Delete user via service request (send delete with http delete method)
    self.delete = function (user) {
        // add confirmation popup
        console.log(user.id());
        var result = confirm("Do you want to delete?");
        if (result) {
            $.ajax({
                method: "POST",
                url: serviceRoot + '/api/users?id=' + user.id(),
                success: function (data) {
                    // add popup Id deleted succesfully
                    self.getUsers();
                    self.genderChecked("1");
                },
                error: function (xhr, status, error) {
                    // check status && error
                    console.log(error);
                },
            });
        }
    }

    // Get roles from service
    self.getRoles = function () {
        // Get request from service and parse to the table
        $.getJSON(serviceRoot + '/api/roles', function (data) {
            var mappedRoles = $.map(data, function (item) {
                return new Role(item.id, item.name);
            });
            self.roles(mappedRoles);
        });
    }
    self.getRoles();

    // Get genders from service
    self.getGenders = function () {
        // Get request from service and parse to the table
        $.getJSON(serviceRoot + '/api/genders', function (data) {
            var mappedGenders = $.map(data, function (item) {
                return new Gender(item.id, item.name);
            });
            self.genders(mappedGenders);
        });
    }
    self.getGenders();

    // select unknown gender initially
    self.genderChecked = ko.observable("1");
}

$(document).ready(function () {
    var appViewModel = new AppViewModel();
    ko.applyBindings(appViewModel);
});