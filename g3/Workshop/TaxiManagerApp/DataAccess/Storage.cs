using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    //Static Database with multiple StorageSets that represent Tables/Collection per type (StaticDb)
    public static class Storage
    {
        public static StorageSet<User> Users { get; set; } = new StorageSet<User>();
        public static StorageSet<Car> Cars { get; set; } = new StorageSet<Car>();

        //static Storage()
        //{
        //    Users = new StorageSet<User>();
        //    Cars = new StorageSet<Car>();
        //}
    }
    //Storage:
        //{
        //Users: {
            //Items: []
            //Add()
        //},
        //Cars: {
            //Items: []
            //Add()
        //}
    //}
}
