using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.Services
{
    public abstract class DataSerializer
    {
        public DataSerializer()
        {
        }

        public abstract T Deserialize<T>(Func<Stream> readStream) where T:class;
        public abstract void Serialize<T>(T data, Func<Stream> writeStream) where T:class;
    }
}
