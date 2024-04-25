using JsonDb.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDb
{
    public class Database<T> where T : BaseEntity
    {
        // private List<T> _items; we don't want to keep data in memory; we want to write it in json file
        private string _folderPath;
        private string _filePath;
        private int _id;

        private void WriteToFile(List<T> data) //ex. List<Subject> List<Student>
        {
            try
            {
                //because we want to write to json file, we need to serialize list to json and send that json to the file
                string jsonData = JsonConvert.SerializeObject(data);
                using(StreamWriter sw = new StreamWriter(_filePath))
                {
                    sw.WriteLine(jsonData);
                }

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
