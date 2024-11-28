using System;
using System.Collections.Generic;
using System.Management.Automation;

namespace Task_Tracker
{

    [Cmdlet(VerbsCommon.Get, "AllTask")]
    [OutputType(typeof(Task))]
    public class GetAllTasks : Cmdlet
    {
        // This is the WriteMethod to Write in Powershell!
        protected override void ProcessRecord()
        {
            WriteObject("Hello World");
        }
    }

    [Cmdlet(VerbsCommon.Add, "NewTask")]
    [OutputType(typeof(Task))]
    public class CreateNewTask : Cmdlet
    {

    }
}