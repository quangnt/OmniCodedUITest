using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;


namespace OmniCodedUITest.Libraries
{
    public class ObjectIdentification
    {
        /// <summary>
        /// Add/Update a search property of a control 
        /// </summary>
        /// <param name="control"></param>
        /// <param name="property"></param>
        /// <param name="value"></param>
        public static void AddUpdateSearchProperties(UITestControl control, string property, string value)
        {
            control.SearchProperties.Add(property, value);
        }

        /// <summary>
        /// Add/Update search properties of a control 
        /// </summary>
        /// <param name="control"></param>
        /// <param name="propertyDict"></param>
        public static void AddUpdateSearchProperties(UITestControl control, Dictionary<string, string> propertyDict)
        {
            PropertyExpressionCollection expCollection = new PropertyExpressionCollection();
            foreach (KeyValuePair<string, string> propValue in propertyDict)
            {
                expCollection.Add(propValue.Key, propValue.Value);
            }
            control.SearchProperties.AddRange(expCollection);
        }

        /// <summary>
        /// Remove search property of a control 
        /// </summary>
        /// <param name="control"></param>
        /// <param name="property"></param>
        public static void RemoveSearchProperties(UITestControl control, string property)
        {
            control.SearchProperties.Remove(property);
        }        
    }
}
