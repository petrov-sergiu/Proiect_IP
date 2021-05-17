using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectIP
{
    {
    public enum StatusTask{
        in_progress = 1,
        completed = 2,
        abandoned = 3
    }

  
    public class Task
    {
        string _taskName;
        string _taskDetails;
        StatusTask _progressTask;
        DateTime _startTask;
        DateTime _endDate;
    

        Task(string taskName, string taskDetails, DateTime startTask, DateTime endDate)
        {
            _taskName = taskName;
            _taskDetails = taskDetails;
            _startTask = startTask;
            _endDate = endDate;
            _progressTask = StatusTask.in_progress;
        }

        public Task(string taskName, string taskDetails, DateTime startTask, DateTime endDate, StatusTask progressTask)
        {
            _taskName = taskName;
            _taskDetails = taskDetails;
            _startTask = startTask;
            _endDate = endDate;
            _progressTask = progressTask;
        }

    }
}
