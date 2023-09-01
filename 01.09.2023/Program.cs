using System.Text.Json;
using System.Text.Json.Serialization;

namespace _01._09._2023
{
    internal static class Program
    {
        public static string PathFile { get; } = "Person.json";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
        public static void SavePerson(Person p)
        {
            string jsonStr = JsonSerializer.Serialize(p);
            File.WriteAllText(PathFile, jsonStr);
        }
        public static Person LoadPerson()
        {
            string jsonStr = File.ReadAllText(PathFile);
            Person p = JsonSerializer.Deserialize<Person>(jsonStr);
            return p;
        }
    }
}