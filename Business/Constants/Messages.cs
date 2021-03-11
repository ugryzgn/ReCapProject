using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string BrandSuccessAdded = "Brand successfully added...";
        public static string CarImageSuccessAdded = "Car image successfully added...";
        public static string CarSuccessAdded = "Car successfully added...";
        public static string ColorSuccessAdded = "Color successfully added...";
        public static string CustomerSuccessAdded = "Customer successfully added...";
        public static string RentalSuccessAdded = "Rental successfully added...";
        public static string UserSuccessAdded = "User successfully added...";

        public static string BrandErrorAdded = "Brand could not be added! The brand name entered must be at least two characters!";
        public static string CarErrorAdded = "Car could not be added! The price entered must be greater than zero!";
        public static string ColorErrorAdded = "Color could not be added! ";
        public static string CustomerErrorAdded = "Customer could not be added!";
        public static string RentalErrorAdded = "Rental could not be added! The car has not delivered yet!";
        public static string UserErrorAdded = "User could not be added! ";

        public static string BrandSuccessDeleted = "Brand successfully deleted...";
        public static string CarImageSuccessDeleted = "Car image successfully deleted...";
        public static string CarSuccessDeleted = "Car successfully deleted...";
        public static string ColorSuccessDeleted = "Color successfully deleted...";
        public static string CustomerSuccessDeleted = "Customer successfully deleted...";
        public static string RentalSuccessDeleted = "Rental successfully deleted...";
        public static string UserSuccessDeleted = "User successfully deleted...";

        public static string BrandErrorDeleted = "Brand could not be deleted!";
        public static string CarErrorDeleted = "Car could not be deleted!";
        public static string ColorErrorDeleted = "Color could not be deleted!";
        public static string CustomerErrorDeleted = "Customer could not be deleted!";
        public static string RentalErrorDeleted = "Rental could not be deleted!";
        public static string UserErrorDeleted = "User could not be deleted!";

        public static string BrandSuccessUpdated = "Brand successfully updated...";
        public static string CarImageSuccessUpdated = "Car image successfully updated...";
        public static string CarSuccessUpdated = "Car successfully updated...";
        public static string ColorSuccessUpdated = "Color successfully updated...";
        public static string CustomerSuccessUpdated = "Customer successfully updated...";
        public static string RentalSuccessUpdated = "Rental successfully updated...";
        public static string UserSuccessUpdated = "User successfully updated...";

        public static string BrandErrorUpdated = "Brand could not be updated! The brand name entered must be at least two characters!";
        public static string CarErrorUpdated = "Car could not be updated! The price entered must be greater than zero!";
        public static string ColorErrorUpdated = "Color could not be updated! ";
        public static string CustomerErrorUpdated = "Customer could not be updated! ";
        public static string RentalErrorUpdated = "Rental could not be updated! ";
        public static string UserErrorUpdated = "User could not be updated! ";

        public static string BrandSuccessGetAll= "Brands successfully listed...";
        public static string CarSuccessGetAll = "Cars successfully listed...";
        public static string ColorSuccessGetAll = "Colors successfully listed...";
        public static string CustomerSuccessGetAll = "Customers successfully listed...";
        public static string RentalSuccessGetAll = "Rentals successfully listed...";
        public static string UserSuccessGetAll = "Users successfully listed...";

        public static string BrandErrorGetAll = "Brands could not be listed!";
        public static string CarErrorGetAll = "Cars could not be listed!";
        public static string ColorErrorGetAll = "Colors could not be listed! ";
        public static string CustomerErrorGetAll = "Customers could not be listed!";
        public static string RentalErrorGetAll = "Rentals could not be listed!";
        public static string UserErrorGetAll = "Users could not be listed! ";

        public static string BrandSuccessGetByID = "The desired brand successfully listed...";
        public static string CarSuccessGetByID = "The desired car successfully listed...";
        public static string ColorSuccessGetByID = "The desired color successfully listed...";
        public static string CustomerSuccessGetByID = "The desired customer successfully listed...";
        public static string RentalSuccessGetByID = "The desired rental successfully listed...";
        public static string UserSuccessGetByID = "The desired user successfully listed...";

        public static string BrandErrorGetByID = "The desired brand could not be listed!";
        public static string CarErrorGetByID = "The desired car could not be listed!";
        public static string ColorErrorGetByID = "The desired color could not be listed!";
        public static string CustomerErrorGetByID = "The desired customer could not be listed!";
        public static string RentalErrorGetByID = "The desired rental could not be listed!";
        public static string UserErrorGetByID = "The desired user could not be listed!";

        public static string BrandSuccessGetBy = "Brands successfully listed...";
        public static string CarSuccessGetBy = "Cars successfully listed...";
        public static string ColorSuccessGetBy = "Colors successfully listed...";
        public static string CustomerSuccessGetBy = "Customers successfully listed...";
        public static string RentalSuccessGetBy = "Rentals successfully listed...";
        public static string UserSuccessGetBy = "Users successfully listed...";

        public static string BrandErrorGetBy = "Brand could not be listed!";
        public static string CarErrorGetBy = "Cars could not be listed!";
        public static string ColorErrorGetBy = "Colors could not be listed! ";
        public static string CustomerErrorGetBy = "Customers could not be listed!";
        public static string RentalErrorGetBy = "Rentals could not be listed!";
        public static string UserErrorGetBy = "Users could not be listed! ";

        public static string BrandSuccessDto = "Brand details successfully listed...";
        public static string CarSuccessDto = "Car details successfully listed...";
        public static string ColorSuccessDto = "Color details successfully listed...";
        public static string CustomerSuccessDto = "Customer details successfully listed...";
        public static string RentalSuccessDto = "Rental details successfully listed...";
        public static string UserSuccessDto = "User details successfully listed...";

        public static string BrandErrorDto = "Brand details could not be listed!";
        public static string CarErrorDto = "Car details could not be listed!";
        public static string ColorErrorDto = "Color details could not be listed! ";
        public static string CustomerErrorDto = "Customer details could not be listed!";
        public static string RentalErrorDto = "Rental details could not be listed!";
        public static string UserErrorDto = "User details could not be listed! ";
        
        public static string ImagesOfCarLimitExceeded = "You've exceeded the image limit! (One car can own most five images) ";
        
        public static string AuthorizationDenied = "You are not authorized for this action!";

        public static string UserRegistered = "User has been successfully registered...";
        public static string UserNotFound = "User not found!";
        public static string PasswordError = "Password is wrong!";
        public static string SuccessfulLogin = "Login successful...";
        public static string UserAlreadyExists = "This user already exists!";
        public static string AccessTokenCreated = "Access token has been successfully created...";
        public static string CarNameAlreadyExist = "There is already a car with the same name!";
        public static string TransactionCanceled = "The transaction has been canceled!";
    }
}
