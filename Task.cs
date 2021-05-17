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
        
        private string _taskName;
        private string _taskDetails;
        private string _pathImage;
        private StatusTask _progressTask;
        private DateTime _startTask;
        private DateTime _endDate;
    

        public Task(string taskName, string taskDetails, string path, DateTime startTask, DateTime endDate)
        {
            _taskName = taskName;
            _taskDetails = taskDetails;
            _pathImage = path;
            _startTask = startTask;
            _endDate = endDate;
            _progressTask = StatusTask.in_progress;
        }

        public Task(string taskName, string taskDetails, string path, DateTime startTask, DateTime endDate, StatusTask progressTask)
        {
            _taskName = taskName;
            _taskDetails = taskDetails;
            _pathImage = path;
            _startTask = startTask;
            _endDate = endDate;
            _progressTask = progressTask;
        }


    }
}
