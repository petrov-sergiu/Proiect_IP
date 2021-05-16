using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectIP
{
    public class ManageTask
    {
        public List<Task> listTask;
        public  ManageTask()
        {
            listTask = new List<Task>();
        }
       
        
        public string AddTask(Task t)
        {
            if(listTask == null)
            {
                listTask = new List<Task>();
            }
            if(Contains(t))
            {
                return "Exista deja";
            }
            listTask.Add(t);
            return "task adaugat";
        }

        public string DeleteTask(Task t)
        {
            for (int i = 0; i < listTask.Count; i++)
            {
                if (t.GetName() == listTask[i].GetName())
                {
                    listTask.RemoveAt(i);
                    return "Task Sters";
                }
            }
            return "Task inexistent";
        }
        private bool Contains(Task t)
        {
            for(int i=0;i<listTask.Count;i++)
            { 
                if (t.GetName() == listTask[i].GetName())
                    return true;
            }
            return false;
        }

    }
}
