// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Tracing;

Dictionary<int, string> dictionary = new Dictionary<int, string>();
{
    dictionary.Add(1,"Yunus");
    dictionary.Add(2, "Emre");
    dictionary.Add(3, "Tarık");
Console.WriteLine(dictionary);
    foreach (KeyValuePair<int,string> mydictionary in dictionary)
    {
        Console.WriteLine("Key : {0}, Value : {1}", dictionary.Keys , dictionary.Values);
    }
}
