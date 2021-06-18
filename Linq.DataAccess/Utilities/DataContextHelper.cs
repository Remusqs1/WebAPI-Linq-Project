using System;
using System.Configuration;
using System.Data.Linq;

namespace Linq.DataAccess.Utilities
{
    public static class DataContextHelper
    {

        public static T GetDataContext<T>() where T : DataContext
        {
            T result;
            string connectionString = ConfigurationManager.ConnectionStrings["LinqDB"].ToString();
            result = (T)Activator.CreateInstance(typeof(T), connectionString);
            return result;
        }
    }

}
