using System;
using System.Collections.Generic;

namespace Playground.Domain
{
    public class ExternalRef
    {
        public Guid Id { get; }
        public Guid Version { get; }
    }


    public class Step
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class AbstractTask<TStep>
        where TStep : Step
    {
        public List<TStep> Steps { get; }

        public void AddStep(TStep step)
        {
            Steps.Add(step);
        }
    }

    public class Activity
    {
        public List<ExternalRef> Tasks { get; set; }
    }


    // public class OotbTask : AbstractTask<Step>
    // {
    //
    // }


    //ATIS==============================================
    public class AtisStep : Step
    {
        public bool IsCritical { get; set; }
    }


    public class AtisTask : AbstractTask<AtisStep>
    {
    }
}