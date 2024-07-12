// See https://aka.ms/new-console-template for more information
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Package_Manager_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            JArray array = new JArray();
            JValue text = new JValue("Manual text");
            JValue date = new JValue(new DateTime(2000, 5, 23));

            array.Add(text);
            array.Add(date);

            string json = array.ToString();
            Console.WriteLine(json);
        }
    }
}
