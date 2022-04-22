/// <reference path="../lib/jquery/dist/jquery.js" />
/// <reference path="knockout-3.5.1.js" />
/// <reference path="knockout.validation.min.js" />
// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//Employee Model in JavaScript
/*
function Employee(data) {
    this.Id = ko.observable(data.Id);
    this.FirstName = ko.observable(data.FirstName);
    this.LastName = ko.observable(data.LastName);
    this.FullAddress = ko.observable(data.FullAddress);
    this.MailingAddressSameAsFullAddress = ko.observable(data.MailingAddressSameAsFullAddress);
    this.MailingAddress = ko.observable(data.MailingAddress);
    this.EmailAddress = ko.observable(data.EmailAddress);
    this.PhoneNumber = ko.observable(data.PhoneNumber);
    this.CitizenshipStatus = ko.observable(data.CitizenshipStatus);
    this.EmploymentStartDate = ko.observable(data.EmploymentStartDate);
    this.EmploymentType = ko.observable(data.EmploymentType);
    this.PositionTitle = ko.observable(data.PositionTitle);
    this.EmergencyContactName = ko.observable(data.EmergencyContactName);
    this.EmergencyContactRelationship = ko.observable(data.EmergencyContactRelationship);
    this.EmergencyContactPhoneNumber = ko.observable(data.EmergencyContactPhoneNumber);
    this.EmployeeSignature = ko.observable(data.EmployeeSignature);
}
*/

//employee view model
function EmployeeViewModel() {
    var self = this;
    self.Id = ko.observable();
    self.FirstName = ko.observable().extend({required: true, minLength: 2} );
    self.LastName = ko.observable().extend({ required: true, minLength: 2 });
    self.FullAddress = ko.observable().extend({ required: true, minLength: 10 });
    self.MailingAddressSameAsFullAddress = ko.observable().extend({ required: true});
    self.MailingAddress = ko.observable().extend({ required: false });
    self.EmailAddress = ko.observable().extend({ required: true, email: true});
    self.PhoneNumber = ko.observable().extend({ required: true, phoneUS: true });
    self.CitizenshipStatus = ko.observable().extend({ required: true });
    self.EmploymentStartDate = ko.observable().extend({ required: true, date: true });
    self.EmploymentType = ko.observable().extend({ required: true });
    self.PositionTitle = ko.observable().extend({ required: true });
    self.EmergencyContactName = ko.observable().extend({ required: true });
    self.EmergencyContactRelationship = ko.observable().extend({ required: true });
    self.EmergencyContactPhoneNumber = ko.observable().extend({ required: true, phoneUS: true  });
    self.EmployeeSignature = ko.observable().extend({ required: true, minLength: 2 });
}


$().ready(function () {
    console.log("from site js");
    ko.applyBindings(new EmployeeViewModel());
});