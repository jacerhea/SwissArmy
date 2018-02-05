using System;
using System.Linq;

namespace SwissArmy.Mapping
{
    public class Mapper
    {
        //public T Map<T>(T item)
        //{
        //    var created = Activator.CreateInstance<T>();
        //    //foreach property map to new item
        //    return created;
        //}

        //public void Map<T>(T source, T destination)
        //{
        //    if (destination == null || source == null)
        //    {
        //        return;
        //    }

        //    var srcProperties = typeof (T)..GetProperties();
        //    var destProperties = typeof (T).GetProperties().ToDictionary(p => p.Name);


        //    foreach (var propertyInfo in srcProperties)
        //    {
        //        var propertyType = propertyInfo.PropertyType;
        //        if (propertyType.IsClass)
        //        {
        //            //var propertyClass = 
        //        }
        //        else if (propertyType.IsValueType)
        //        {
        //            if (destProperties.ContainsKey(propertyType.Name))
        //            {
        //                destProperties[propertyType.Name].SetValue(destination, propertyInfo.GetValue(source, null), null);
        //            }
        //        }


        //    }



        //    //foreach property map to destination
        //}
    }
}
