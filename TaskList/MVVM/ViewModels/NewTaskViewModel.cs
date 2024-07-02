using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskList.MVVM.Models;

namespace TaskList.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class NewTaskViewModel
    {
        #region Properties
        public string? Task { get; set; }
        public ObservableCollection<MyTask>? Tasks { get; set; }
        public ObservableCollection<Category>? Categories { get; set; }
        #endregion

    }
}
