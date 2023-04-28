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
        protected readonly Func<Stream> streamGetter;

        public DataSerializer(Func<Stream> getter)
        {
            this.streamGetter = getter;
        }

        public abstract T Deserialize<T>(Func<Stream>? getter = null) where T:class;
        public abstract void Serialize<T>(T data, Func<Stream>? getter = null) where T:class;
    }
}
