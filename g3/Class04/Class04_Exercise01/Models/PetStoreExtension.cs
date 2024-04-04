namespace Models
{
    public static class PetStoreExtension
    {
        public static string GetStoreInfo<T>(this PetStore<T> store) where T : Pet
        {
            return $"Store: {store.Name}\n" + store.GetPets();
        }
    }
}
