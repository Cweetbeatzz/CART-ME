using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace CART_ME.SQLconfig
{
    public class SQLconnection
    {
        public static string GetConnectionString( string DBconnectionName)
        {
            return ConfigurationManager.ConnectionStrings["CART-ME-DB"].ConnectionString;
        }
    }
}