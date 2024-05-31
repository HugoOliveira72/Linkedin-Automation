using MessagePack;
using Newtonsoft.Json;

namespace forms.Utilities
{
    public class Mapper
    {
        public T MapToObject<T>(byte[] messagePackBytes)
        {
            try
            {
                // Desserializa os bytes usando MessagePack
                var loadedObject = MessagePackSerializer.Deserialize<T>(messagePackBytes);

                // Serializa o objeto para JSON
                var json = JsonConvert.SerializeObject(loadedObject);

                // Desserializa o JSON para o tipo de objeto desejado
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception ex)
            {
                // Lida com exceções (por exemplo, se a desserialização falhar)
                Console.WriteLine($"Error mapping object: {ex.Message}");
                return default(T);
            }
        }
    }
}
