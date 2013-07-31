using System;

namespace SwissArmy.Mapping
{
    public class Mapper
    {
        public T Map<T>(T item)
        {
            var created = Activator.CreateInstance<T>();
            //foreach property map to new item
            return created;
        }

        public void Map<T>(T source, T destination)
        {
            //foreach property map to destination
        }
    }
}
