using System;
using System.Collections.Generic;

namespace Playground.Domain
{
    public class Reference
    {
        public Guid Id { get; }
        public Guid Version { get; }
    }

    public class Step
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }


    public class Task
    {
        public List<Step> Steps { get; set; }
    }
}