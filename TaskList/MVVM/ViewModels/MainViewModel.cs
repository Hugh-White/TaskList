using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskList.MVVM.Models;

namespace TaskList.MVVM.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        //ObservableCollection to hold the list of categories users may add
        public ObservableCollection<Category>? Categories { get; set; }
        public ObservableCollection<MyTask>? Tasks { get; set; }
        #endregion

        #region Constructor
        public MainViewModel() 
        {
            FillData();   
        }


        #endregion

        #region Methods

        //Method to populate the categories and tasks
        private void FillData()
        {
            Categories = new ObservableCollection<Category> 
            {
                new Category
                {
                    Id = 1,
                    CategoryName = ".NET MAUI Course",
                    Colour = "#CF14DF"
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Tutorials",
                    Colour = "#DF6F14"
                },
                new Category
                {
                    Id = 3,
                    CategoryName = "Coding Degree",
                    Colour = "#14DF80"
                }

            };

            Tasks = new ObservableCollection<MyTask>
            {
                new MyTask
                {
                    TaskName = "Complete Maui Videos",
                    Completed = true,
                    CategoryId = 1,

                },
                new MyTask
                {
                    TaskName = "Learn SQLite for Android",
                    Completed = true,
                    CategoryId = 2,

                },
                new MyTask
                {
                    TaskName = "Upload school files",
                    Completed = false,
                    CategoryId = 3,

                },
                new MyTask
                {
                    TaskName = "Finish MAUI Portfolio",
                    Completed = false,
                    CategoryId = 1,

                },
                new MyTask
                {
                    TaskName = "Finish final HCI exam",
                    Completed = true,
                    CategoryId = 3,

                },
                new MyTask
                {
                    TaskName = "Recieve Bachelors grade for study",
                    Completed = false,
                    CategoryId = 3,

                },
                new MyTask
                {
                    TaskName = "Find JavaScript Tutorials to build clean frontend",
                    Completed = true,
                    CategoryId = 2,

                },
                new MyTask
                {
                    TaskName = "Learn common stacks for employment with JS (React, Vue, Ember, Angular",
                    Completed = false,
                    CategoryId = 2,

                }
            };

            //Calling method to calculate things like percentage complete, colours of tasks etc.
            UpdateData();
        }

        //Method to match tasks with categories through their Id properties. 
        //Also sets properties of categories for pending tasks & percentage, as well as the TaskColour property ofa task based on the category colour.
        public void UpdateData()
        {
            foreach (var c in Categories) 
            {
                var tasks = from t in Tasks 
                            where t.CategoryId == c.Id 
                            select t;
                var completed = from t in tasks
                                where t.Completed == true
                                select t;
                var notCompleted = from t in tasks
                                   where t.Completed == false
                                   select t;

                c.PendingTasks = notCompleted.Count();
                c.Percentage = (float)completed.Count() / (float)tasks.Count();
            }

            foreach (var t in Tasks)
            {
                var catColour = (from c in Categories
                                 where c.Id == t.CategoryId
                                 select c.Colour).FirstOrDefault();
                t.TaskColour = catColour;
            }
        }
        #endregion
    }
}
