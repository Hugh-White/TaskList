﻿using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Category
    {
        public int? Id { get; set; }
        public string? CategoryName { get; set; }
        public string? Colour { get; set; }
        public int? PendingTasks { get; set; }
        public float? Percentage { get; set; }
    }
}
