using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added";
        public static string ProductNameInvalid = "Product name is invalid";
        public static string MaintenanceTime = "System in maintenance time";
        public static string ProductListed = "Products Listed";
        public static string ProductCountOfCategoryError="Maximum 10 products must in a category";
        public static string ProductNameAlreadyExists="This Prdocut Name is alrwady exists";
        public static string CategoryLimitExceeded= "Category limit exceeded";
        public static string ProductUpdated="Product updated successfulyy";
        public static string AuthorizationDenied = "Authorization Denied";
        internal static string AccessTokenCreated= "Access Token Created";
        internal static string UserAlreadyExists= "User Already Exists";
        internal static string SuccessfulLogin= "Successful Login";
        internal static string PasswordError= "Password Error";
        internal static string UserNotFound= "User Not Found";
        internal static string UserRegistered= "User Registered";
    }
}
