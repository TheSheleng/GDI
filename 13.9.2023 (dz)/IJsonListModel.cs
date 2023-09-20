using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace _13._9._2023__dz_
{
    public interface IJsonListModel<T>
    {
        public string PathFile { get; set; }

        public void SaveToList(T value);

        public List<T> GetList();
    }
}
