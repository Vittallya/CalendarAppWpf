using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CalendarApp.Models
{
    internal class CalendarInfo
    {
        public DayInfo[] DayEvents { get; set; }
    }
}
