﻿using CalendarApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CalendarApp.Models
{
    public class DayInfo: BaseViewModel
    {
        [JsonPropertyOrder(0)]
        public DateTime Date { get; set; }

        [JsonPropertyOrder(2)]
        public string? UriImage { get; set; }
        [JsonPropertyOrder(1)]
        public bool[] Selections { get; set; }
    }
}
