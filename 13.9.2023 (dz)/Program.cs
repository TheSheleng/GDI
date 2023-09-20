using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace _13._9._2023__dz_
{
    internal static class Program
    {
        static IJsonListModel<Person>? jsonList = null;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            jsonList = new JsonListModel<Person>();
            jsonList.PathFile = "person.json";

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }

        static public void SavePersone(Person p)
        {
            jsonList?.SaveToList(p);
        }

        static public List<Person>? GetPersons(string? filter)
        {
            List<Person>? persons = jsonList?.GetList();

            if (filter == null || persons == null)
            {
                return persons;
            }

            List<Person>? filteredPersons = new List<Person>();
            foreach (var p in persons)
            {
                if (p.Name.Contains(filter))
                {
                    filteredPersons.Add(p);
                }
            }

            return filteredPersons;
        }
    }
}