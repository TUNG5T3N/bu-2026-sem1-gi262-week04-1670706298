using NUnit;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            // LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
            // LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            throw new System.NotImplementedException();
        }

        public void LCT02_SyntaxLinkedList()
        {
            throw new System.NotImplementedException();
        }

        public void LCT03_SyntaxHashTable()
        {
            throw new System.NotImplementedException();
        }

        public void LCT04_SyntaxDictionary()
        {
            throw new System.NotImplementedException();
            /*Dictionary<string, int> dic = new Dictionary<string, int>();
            var inv2 = new Dictionary<string, int>();

            // "Potion": 1
            inv.Add("Potion", 1);

            // "Potion": 1
            // "Apple": 10
            inv.Add("Apple", 10);

            // "Potion": 1
            // "Apple": 10
            // "Banana": 5
            inv["Banana"] = 5;

            // "Potion": 10
            // "Apple": 10
            // "Banana": 5
            inv["Potion"] = 10;

            var pickupItem = "Sword";
            // "Potion": 10
            // "Apple": 10
            // "Banana": 5
            // "Sword": 5
            inv[pickupItem] = 1;

            //foreach (KeyValuePair<string, int> pair in inv)
            foreach ( var pair in inv)
            {
                string key = pair.Key;
                int value = pair.Value;
                Debug.Log($"Key: {key} value: {value}");
            }

            var appleExists = inv2.ContainsKey("Apple");
            Debug.Log(appleExists);

            var keyExists = inv2.ContainsKey("Key");
            Debug.Log(keyExists);

            inv2.Remove("Apple");

            foreach (var pair in inv)
            {
                string key = pair.Key;
                int value = pair.Value;
                Debug.Log($"Key: {key} value: {value}");
            }*/
        }

        #endregion
    }
}
