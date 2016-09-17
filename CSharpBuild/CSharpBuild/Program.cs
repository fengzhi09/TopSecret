using CSharpBuild.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Any())
            {
                try
                {
                    List<BuildTask> buildTaskList = new List<BuildTask>();
                    foreach (var arg in args)
                    {
                        if (HelpInfoTool.IsValid(arg))
                        {
                            BuildTask task;
                            if (BuildTaskFactory.TryGetTask(args, out task))
                            {
                                buildTaskList.Add(task);
                            }
                        }
                    }
                    buildTaskList.OrderBy(task => task.TaskType);
                    foreach (var task in buildTaskList){
                        task.Action();
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {

                }
                
            }
            HelpInfoTool.ShowAllInfo();
        }
    }

    internal class BuildTaskFactory
    {
        internal static bool TryGetTask(string[] args, out BuildTask task)
        {
            throw new NotImplementedException();
        }
    }
}
