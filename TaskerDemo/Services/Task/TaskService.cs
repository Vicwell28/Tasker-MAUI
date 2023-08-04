using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskerDemo.Models;

namespace TaskerDemo.Services.Task
{
	public class TaskService : ITaskService
	{
		public ObservableCollection<Category> GetCategories()
		{
			return new ObservableCollection<Category>
			{
				new Category
				{
					Id = 1,
					CategoryName = ".NET MAUI Course",
					Color = "#CF14DF"
				},
				new Category
				{
					Id = 2,
					CategoryName = "SICAV",
					Color = "#df6f14"
				},
				new Category
				{
					Id = 3,
					CategoryName = "PCD",
					Color = "#14df80"
				}
			};
		}

		public ObservableCollection<MyTask> GetTasks()
		{
			return new ObservableCollection<MyTask>
			{
				new MyTask
				{
						TaskName = "Upload exercise files",
						Completed = false,
						CategoryId = 1
				},
				new MyTask
				{
						TaskName = "Plan next course",
						Completed = false,
						CategoryId = 1
				},
				new MyTask
				{
						TaskName = "Upload new ASP.NET",
						Completed = false,
						CategoryId = 2
				},
				new MyTask
				{
						TaskName = "Fix Settings.cs class of the project",
						Completed = false,
						CategoryId = 2
				},
				new MyTask
				{
						TaskName = "Update github repository",
						Completed = true,
						CategoryId = 2
				},
				new MyTask
				{
						TaskName = "Document",
						Completed = false,
						CategoryId = 3
				},
				new MyTask
				{
						TaskName = "Fix Settings.cs class of the project",
						Completed = false,
						CategoryId = 3
				},
			};
		}
	}
}
