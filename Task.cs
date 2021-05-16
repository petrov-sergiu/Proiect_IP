using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectIP
{
    public class Task
    {
        private string _name;
        private string _status;
        private string _pathImage;

        public Task(string name, string status,string _path)
        {
            _name = name;
            _status = status;
            _pathImage = _path;
        }
        public string GetName()
        {
            return _name;
        }

    }
}
