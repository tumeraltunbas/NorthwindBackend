using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added";
        public static string ProductNameInvalid = "Invalid product name";
        public static string MaintenanceTime ="Maintenance time";
        public static string ProductsListed ="Listed products";
        public static string ProductCountOfCategoryError= "There can be a maximum of 10 products in a category";
        public static string ProductNameAlreadyExists= "There is already another product with this name";
        public static string CategoryLimitExceded = "New products cannot be added because the category limit has been exceeded.";
        public static string AuthorizationDenied= "You have no authorization.";
    }
}
