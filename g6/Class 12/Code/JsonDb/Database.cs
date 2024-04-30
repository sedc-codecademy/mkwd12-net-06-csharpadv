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


        public Database() {

            _folderPath = @"..\..\..\Database";
            // ..\..\..\Database\Students.json
            //..\..\..\Database\Subjects.json
            _filePath = _folderPath + $@"\{typeof(T).Name}s.json"; //with typeOf we get the type of T - Student, Subject...

            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }

            if(!File.Exists(_filePath)) {
                //we will try to read from the file;
                //the StreamReader does not create the file if it does not exist (only the StreamWriter creates one)
                //so we need to create it manually before trying to read from the file in case id does not already exist
                File.Create(_filePath).Close(); 
            }

            //read from the json file and if there are records take the last Id
            List<T> data = ReadFromFile();
            if(data == null)
            {
                //inavalid json or file was empty
                _id = 0; 
            }
            else
            {
                if(data.Count > 0)
                {
                    _id = data.Last().Id;
                }
                else
                {
                    _id = 0; 
                }
            }

        }
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

        private List<T> ReadFromFile()
        {
            try
            {
                using(StreamReader sr = new StreamReader(_filePath))
                {
                    string data = sr.ReadToEnd(); //read the whole file
                    return JsonConvert.DeserializeObject<List<T>>(data);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; //our catch only writes in the console and our method expects a return so we return null
            }
        }

        public List<T> GetAll()
        {
            List<T> data = ReadFromFile();
            return data;
        }

        public T GetById(int id)
        {
            List<T> data = ReadFromFile();
           if(data != null)
            {
                return data.FirstOrDefault(x => x.Id == id);
            }
            else { return null; }
            
        }

        public void Insert(T item)
        {
            List<T> data = ReadFromFile();
            if(data == null)
            {
                data = new List<T>();
            }
            _id++;
            item.Id = _id;
            data.Add(item);
            WriteToFile(data);
        }
    }
}
