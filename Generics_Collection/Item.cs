using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Collection
{
    public class Item 
    {
        public string name { get; set; }
        public string ItemId { get; set; }        
        protected int? Quantity { get; set; }
        public System.DateTime DateCreated { get; set; }
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        Dictionary<string, string> items_category = new Dictionary<string, string>();
        public void Add_In_Dictionary(string key, string value) {
            items_category.Add(key,value);
        }
        public void Display_Dictionary()
        {
            foreach (KeyValuePair<string, string> kvp in items_category)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }

        }
    }
}
