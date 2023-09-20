using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _13._9._2023__dz_
{
    internal class JsonListModel<T> : IJsonListModel<T>
    {
        public string? PathFile { get; set; } = null;

        void CreateNotExists()
        {
            if (!File.Exists(PathFile)) 
            {
                File.Create(PathFile).Close();
            }

            else Console.WriteLine("Файл уже существует.");
        }

        public void SaveToList(T value)
        {
            try
            {
                CreateNotExists();

                string jsonStr = File.ReadAllText(PathFile);
                List<T> list;

                try
                {
                    list = JsonSerializer.Deserialize<List<T>>(jsonStr);
                    Console.WriteLine("Десериализация прошла успешно.");
                }
                catch (JsonException ex)
                {
                    list = new List<T>();
                }

                list.Add(value);
                File.WriteAllText(PathFile, JsonSerializer.Serialize(list));
            }
            catch 
            { 
                throw new Exception("Error: JsonListModel.SaveToList");
            }
        }

        public List<T> GetList()
        {
            try
            {
                CreateNotExists();

                string jsonStr = File.ReadAllText(PathFile);
                return JsonSerializer.Deserialize<List<T>>(jsonStr);
            }
            catch
            {
                throw new Exception("Error: JsonListModel.GetList");
            }
        }
    }
}
