using Newtonsoft.Json;
using QinshiftAcademy.TryBeingFit.Domain.Models;

namespace QinshiftAcademy.TryBeingFit.Domain.Database
{
    public class FileDatabase<T> : IDatabase<T> where T : BaseEntity
    {

        private string _folderPath;
        private string _filePath;
        private int _id;

        public FileDatabase()
        {
            _id = 0;
            _folderPath = @"..\..\..\Db";
            _filePath = _folderPath + @$"\{typeof(T).Name}.json";
            if(!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }
            if(!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
                WriteData(new List<T>());
            }
        }

        public void DeleteById(int id)
        {
            List<T> dbEntities = GetAllEntitiesFromDb();
            T EntityDb = dbEntities.FirstOrDefault(x => x.Id == id);
            if(EntityDb == null)
                throw new Exception($"The entity with id {id} does not exist!");

            dbEntities.Remove(EntityDb);
            WriteData(dbEntities);
        }

        public List<T> GetAll()
        {
            return GetAllEntitiesFromDb();
        }

        public T GetById(int id)
        {
            List<T> dbEntities = GetAllEntitiesFromDb();
            return dbEntities.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(T entity)
        {
            List<T> dbEntities = GetAllEntitiesFromDb();
            if (dbEntities == null)
            {
                dbEntities = new List<T>();
                _id = 1;
            }
            else
            {
                _id = dbEntities.Count + 1;
            }
            entity.Id = _id;
            dbEntities.Add(entity);
            WriteData(dbEntities);
            return entity.Id;
        }

        public void Update(T entity)
        {
            List<T> dbEntities = GetAllEntitiesFromDb();
            T entityDb = dbEntities.FirstOrDefault(x => x.Id == entity.Id);
            if (entityDb == null)
                throw new Exception($"The entity with id {entity.Id} does not exist!");

            dbEntities[dbEntities.IndexOf(entityDb)] = entity;
            WriteData(dbEntities);
        }

        private void WriteData(List<T> dbEntities)
        {
            using (StreamWriter streamWriter = new StreamWriter(_filePath))
            {
                streamWriter.WriteLine(JsonConvert.SerializeObject(dbEntities));
            }
        }

        private List<T> GetAllEntitiesFromDb()
        {
            using (StreamReader streamReader = new StreamReader(_filePath))
            {
                return JsonConvert.DeserializeObject<List<T>>(streamReader.ReadToEnd());
            }
        }
    }
}
