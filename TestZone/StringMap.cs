using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    public interface IStringMap<TValue> where TValue : class
    {
        /// <summary>Returns number of elements in a map</summary>
        int Count { get; }

        /// <summary>
        /// If <c>GetValue</c> method is called but a given key is not in a map then <c>DefaultValue</c> is returned.
        /// </summary>
        TValue DefaultValue { get; set; }

        /// <summary>
        /// Adds a given key and value to a map.
        /// If the given key already exists in the map, then the value associated with this key should be overridden.
        /// </summary>
        /// <returns>true if the value for the key was overridden, otherwise false</returns>
        /// <exception cref="System.ArgumentNullException">If the key is null</exception>
        /// <exception cref="System.ArgumentException">If the key is an empty string</exception>
        /// <exception cref="System.ArgumentNullException">If the value is null</exception>
        bool AddElement(string key, TValue value);

        /// <summary>
        /// Removes a given key and associated value from a map.
        /// </summary>
        /// <returns>true if the key was in the map and was removed, otherwise false</returns>
        /// <exception cref="System.ArgumentNullException">If the key is null</exception>
        /// <exception cref="System.ArgumentException">If the key is an empty string</exception>
        bool RemoveElement(string key);

        /// <summary>
        /// Returns the value associated with a given key.
        /// </summary>
        /// <returns>The value associated with a given key or <c>DefaultValue</c> if the key does not exist in a map</returns>
        /// <exception cref="System.ArgumentNullException">If the key is null</exception>
        /// <exception cref="System.ArgumentException">If the key is an empty string</exception>
        TValue GetValue(string key);
    }
    public class StringMap<TValue> : IStringMap<TValue> where TValue : class
    {
        private List<string> Keys { get; set; } = new List<string>();
        private List<TValue> Values { get; set; } = new List<TValue>();

        public StringMap()
        {
        }

        public int Count => Keys.Count();

        public TValue DefaultValue { get => default(TValue); set => throw new NotImplementedException(); }

        public bool AddElement(string key, TValue value)
        {
            try
            {
                Values.Add(value);
                Keys.Add(key);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public TValue GetValue(string key)
        {
            try
            {
                int index = Keys.FindIndex(x => x == key);
                return Values[index];
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public bool RemoveElement(string key)
        {
            try
            {
                int index = Keys.FindIndex(x => x == key);
                Keys.RemoveAt(index);
                Values.RemoveAt(index);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
