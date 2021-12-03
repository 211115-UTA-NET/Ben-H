
//A dictionary in C# stores <Key, Value> pairs in no particular order. 
//Index is not numbered.
using System.Collection.Generics;

Dictionary<int, string> myDictionary = new Dictionary<int, string>();

//Add key value pairs to the dictionary using Add() method

myDictionary.Add(1, "Hello");
myDictionary.Add(2, "Goodbye");

//Keys must be unique and cannot be null.
//Values can be null or duplicate.

myDicitonary.Add(3, null);
myDicitonary.Add(4, "Hello");

//Values can be accessed by passing associated key in the indexer

Console.WriteLine(myDicitonary[1]);
Console.WriteLine(myDicitonary[2]);
Console.WriteLine(myDicitonary[3]);
Console.WriteLine(myDicitonary[4]);

//You cannot assign multiple values to the same key.
//myDicitonary.Add(3, "Three"); -- this would return a runtime error

Dictionary<string, string> stringDictionary = new Dictionary<string, string>();

stringDictionary.Add("one", "Hello");
stringDictionary.Add("two", "Goodbye");

Console.WriteLine(stringDicitonary["one"]);
Console.WriteLine(stringDicitonary["two"]);

//Remove() method to remove key value pairs

stringDicitonary.Remove("one");

//ContainsKey() and ContainsValue() methods check the dictionary to see if the dictionary contains the specified key or value

stringDictionary.ContainsKey("one");
stringDictionary.ContainsValue("Goodbye");

//Clear() method clears entire dictionary

stringDicitonary.Clear();


foreach(KeyValuePair<int, string> ele1 in myDictionary)
          {
              Console.WriteLine("{0} and {1}",
                        ele1.Key, ele1.Value);
          }
          Console.WriteLine();





