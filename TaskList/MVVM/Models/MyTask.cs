using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList.MVVM.Models
{
    public class MyTask
    {
        #region Properties
        public string? TaskName {  get; set; }
        public bool? Completed { get; set; }
        public int? CategoryId { get; set; }
        public string? TaskColour { get; set; }

        #endregion
    }
}
