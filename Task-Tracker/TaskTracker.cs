using System.Management.Automation;
using Task_Tracker.Data;
using Task_Tracker.Service;

namespace Task_Tracker
{
    [Cmdlet(VerbsCommon.Get, "AllTask")]
    [OutputType(typeof(Task))]
    public class GetAllTasks : Cmdlet
    {
        // This is the WriteMethod to Write in Powershell!
        protected override void ProcessRecord()
        {
            WriteObject("item");
        }
    }

    [Cmdlet(VerbsCommon.Add, "Task")]
    public class CreateNewTask : Cmdlet
    {
        [Parameter(Mandatory = true)]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string id;

        [Parameter(Mandatory = true)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string name;

        [Parameter(Mandatory = true)]
        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }
        private string desc;

        protected override void ProcessRecord()
        {
            WriteObject("Id:" + id);
            WriteObject("Name:" + name);
            WriteObject("Beschreibung:" + desc);
        }
    }
}