using System;

namespace CSharpBuild
{
    internal class BuildTask
    {
        public TaskType TaskType { get; internal set; }

        internal void Action()
        {
            throw new NotImplementedException();
        }
    }

    public enum TaskType
    {
    }
}