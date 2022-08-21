using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryExample
{
    public class MyDictionary<K,V>
    {
        // Class Properties, not gettable and not settable from outside Class.
        private K[] key { get; set; }
        private V[] value { get; set; }

        //Default Constructor Method  
        public MyDictionary()
        {
            key= new K[0];
            value= new V[0];
        }
       
        //Add Method for MyDictionary Class
        public void Add(K item1,V item2)
        {
            //I Created the temporary arrays.
            K[] temporary = key;
            V[] temporary2 = value;

            //I increased the length of the property arrays.
            key = new K[key.Length + 1];
            value = new V[key.Length + 1];

            //I have put the elements from the temporary array into the extended array.
            for (int i = 0; i < temporary.Length; i++)
            {
                key[i] = temporary[i];
                value[i] = temporary2[i];
            }
            // I have put the new parameters in extended arrays.
            key[key.Length - 1] = item1;
            value[key.Length - 1] = item2;
        }

        //Writing Method for key and value objects in MyDictionary Class
        public void Write()
        {
            for (int i = 0; i < key.Length; i++)
            {
                Console.WriteLine($"{key[i].ToString()} ----------> {value[i].ToString()}");
            }
        }

    }
}
