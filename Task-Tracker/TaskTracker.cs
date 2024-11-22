using System;
using System.Collections.Generic;
using System.Management.Automation;

namespace Task_Tracker
{

    [Cmdlet(VerbsCommon.Get, "NITPerf")]
    [OutputType(typeof(Task))]
    public class TaskTracker : Cmdlet
    {

        private string myparameter;
        private string myparameter2;
        private string myparameter3;

        [Parameter]
        public string Myparameter { get => myparameter; set => myparameter = value; }

        [Parameter(ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public string Myparameter2 { get => myparameter2; set => myparameter2 = value; }

        [Parameter]
        public string Myparameter3 { get => myparameter3; set => myparameter3 = value; }
        protected override void ProcessRecord()
        {

            /*
            Console.WriteLine("Hello World3");
            var re = new MyReturn();
            re.Name = "A1";
            re.Description = "Beschreibung";
            */

            Random ro = new Random();

            List<Task> returnList = new List<Task>();
            for (int i = 0; i < 10; i++)
            {
                var r1 = new Task();
                r1.Name = ro.Next().ToString();
                r1.Description = ro.Next().ToString();
                WriteObject(r1);
                // returnList.Add(r1);
            }

            // ReadOnlyCollection<MyReturn> re = new ReadOnlyCollection<MyReturn>(returnList);
            //WriteObject(returnList);
        }
    }
}