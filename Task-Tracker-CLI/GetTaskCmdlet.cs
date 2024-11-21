using System.Runtime;
using System.Management.Automation;

namespace Task_Tracker_CLI
{
    [Cmdlet(VerbsCommon.Get, "Task")]
    [OutputType(typeof(Task))]
    public class GetTaskCmdlet : Cmdlet
    {
    }
}
