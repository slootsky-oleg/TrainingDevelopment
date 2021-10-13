// using System;
//
// namespace Playground.Domain
// {
//     public class ExternalRef
//     {
//         public Guid Id { get; }
//         public Guid Version { get; }
//     }
//
//     public class Task
//     {
//         private Step step;
//         public virtual Step Step => step;
//
//         public virtual void SetStep(Step newStep)
//         {
//             step = newStep;
//         }
//     }
//
//     public class Step
//     {
//         public Guid Id { get; set; }
//         public string Name { get; set; }
//     }
//
//
//     //=====================================================
//     public class AtisTask : Task
//     {
//         private AtisStep step;
//
//         public override AtisStep Step => step;
//
//         public void SetStep(AtisStep newStep)
//         {
//             step = newStep;
//         }
//
//     }
//
//
//     public class AtisStep : Step
//     {
//         public bool IsCritical { get; set; }
//     }
// }