using System;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Tracker_CLI
{
    public class Task
    {
        public int TaskID { get; set; }
        public string? TaskName { get; set; }
        public string? TaskDesc { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
