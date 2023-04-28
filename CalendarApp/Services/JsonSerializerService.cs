using System;
using System.IO;
using System.Text.Json;

namespace CalendarApp.Services
{
    internal class JsonSerializerService : DataSerializer
    {
        public JsonSerializerService(Func<Stream> getter) : base(getter)
        {
        }

        public override T? Deserialize<T>(Func<Stream>? streamFunc = null)
            where T : class
        {
            using var stream = streamFunc?.Invoke() ?? streamGetter();
            using StreamReader reader = new(stream);
            string json = reader.ReadToEnd();

            try
            {
                return JsonSerializer.Deserialize<T?>(json);
            }
            catch(Exception ex) { }


            return null;
        }

        public override void Serialize<T>(T data, Func<Stream>? streamFunc = null)
            where T : class
        {
            string json = JsonSerializer.Serialize(data);
            using var stream = streamFunc?.Invoke() ?? streamGetter();
            using StreamWriter writer = new(stream);
            writer.Write(json);
        }
    }
}
