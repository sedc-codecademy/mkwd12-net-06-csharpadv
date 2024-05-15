using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryBeingFit.Domain.Models;

namespace TryBeingFit.Domain.Database
{
    public class FileDatabase<T> : IDatabase<T> where T : BaseEntity
    {
        private string _folderPath;
        private string _filePath;
        private int _id;

        public FileDatabase()
        {
            _folderPath = @"..\..\..\FileDatabase";
            _filePath = _folderPath + $@"\{typeof(T).Name}s.json";

            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }
            if (!File.Exists(_filePath))
            {

                File.Create(_filePath).Close();
                WriteEntitiesToFile(new List<T>());
            }

            if (File.Exists(_filePath))
            {
                List<T> dbEntites = ReadEntitiesFromFile();
                if(dbEntites != null && dbEntites.Any())
                {
                   // _id = dbEntites.Last().Id + 1;
                    _id = dbEntites.Last().Id;
                }
                else
                {
                    // _id = 1;
                    _id = 0;
                }
            }
            else
            {
                _id = 0;
            }

           
        }
        public List<T> GetAll()
        {
            return ReadEntitiesFromFile();
        }

        public T GetById(int id)
        {
            List<T> entities = ReadEntitiesFromFile();
            return entities.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(T entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity cannot be null");
            }
            entity.Id = ++_id; //++_id - first increment the id, then assign it to entity.Id
            List<T> dbEntities = ReadEntitiesFromFile();

            if(dbEntities == null)
            {
                dbEntities = new List<T>(); 
            }
            dbEntities.Add(entity);

            //write to file
            WriteEntitiesToFile(dbEntities);
            return entity.Id;
        }

        public void RemoveById(int id)
        {
            List<T> dbEntities = ReadEntitiesFromFile();
            T entityForRemove = dbEntities.FirstOrDefault(x => x.Id == id);
            if (entityForRemove == null)
            {
                throw new Exception($"Entity with id {id} was not found");
            }
            dbEntities.Remove(entityForRemove);
            WriteEntitiesToFile(dbEntities);

        }

        public void Update(T entity)
        {
            if(entity == null)
            {
                throw new NullReferenceException($"Entity cannot be null");
            }
            List<T> dbEntities = ReadEntitiesFromFile();
            T entityForUpdate = dbEntities.FirstOrDefault(x=> x.Id == entity.Id);
            if (entityForUpdate == null)
            {
                throw new Exception($"Entity with id {entity.Id} was not found");
            }

            int index = dbEntities.IndexOf(entityForUpdate); //find the index of the entity that needs to be updated
            dbEntities[index] = entity; //update the entity according to the index
            WriteEntitiesToFile(dbEntities);
        }


        #region Private 

        private List<T> ReadEntitiesFromFile()
        {
            //read the content from file
            string content = ""; //string.Empty
            using (StreamReader reader = new StreamReader(_filePath))
            {
                content = reader.ReadToEnd();
            }
            //deserialization
            List<T> result = JsonConvert.DeserializeObject<List<T>>(content);
            return result;
        }
        private void WriteEntitiesToFile(List<T> entities)
        {
            using(StreamWriter writer = new StreamWriter(_filePath))
            {
                //serialize
                string newContent = JsonConvert.SerializeObject(entities);

                //write
                writer.WriteLine(newContent);
            }
        }

        #endregion
    }
}
