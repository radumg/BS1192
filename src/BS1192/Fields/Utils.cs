using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BS1192.Standard;

namespace BS1192.Fields
{
    public static class Utils
    {
        /// <summary>
        /// Get the list of properties of an object
        /// </summary>
        /// <param name="obj">The object to retrieve properties of.</param>
        /// <returns>A Dictionary with Property Name as the key and its corresponding Value</returns>
        public static Dictionary<string, object> DictionaryFromType(object obj)
        {
            if (obj == null) throw new Exception("DictionaryFromType : Object cannot be null.");

            if (obj == null) return new Dictionary<string, object>();
            Type t = obj.GetType();
            PropertyInfo[] props = t.GetProperties();
            Dictionary<string, object> dict = new Dictionary<string, object>();

            // iterate over its properties
            foreach (PropertyInfo prp in props)
            {
                object value = prp.GetValue(obj, new object[] { });
                dict.Add(prp.Name, value);
            }
            return dict;
        }

        /// <summary>
        /// Get the property values of a class based on the property names supplied
        /// </summary>
        /// <param name="field">Object holding the properties</param>
        /// <param name="propertyName">Properties names, as a list of strings</param>
        /// <returns>The values of the specified properties, as a list</returns>
        public static List<object> GetPropertyValues(object field, List<string> propertyNames)
        {
            if (field == null) throw new Exception("GetPropertyValues : Field cannot be a null value.");

            var values = new List<object>();
            foreach (var name in propertyNames)
            {
                values.Add(
                    field.GetType().GetProperties()
                   .Single(pi => pi.Name == name)
                   .GetValue(field, null)
               );
            }

            return values;
        }

    }
}
