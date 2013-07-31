namespace SwissArmy
{
    public class ObjectCloner
    {
        public static T CloneObject<T>(T entity)
        {
            var serializer = new BinarySerializer();
            var array = serializer.SerializeToBinary(entity);
            return serializer.DeserializeFromBinary<T>(array);
        }
    }
}
