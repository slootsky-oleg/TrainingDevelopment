﻿using System.Collections.Generic;
using System.Linq;
using Domain.Entities.TrainingDevelopment;
using Domain.Entities.TrainingDevelopment.Abstractions;
using Domain.Entities.TrainingDevelopment.Abstractions.Evaluation;
using Domain.Entities.TrainingDevelopment.Abstractions.Prerequisities;
using Domain.Entities.TrainingDevelopment.Abstractions.ResourceRequirements;
using Domain.Entities.TrainingDevelopment.Abstractions.Seats;
using Domain.Entities.TrainingDevelopment.Abstractions.TargetAudience;
using Domain.Entities.TrainingDevelopment.Tasks;

namespace Domain.Atis.Entities.TrainingDevelopment
{
    public class AtisStep : 
        TrainingDevelopmentEntity,
        IEvaluable,
        IHasPrerequisites,
        IHasResourceRequirements,
        IHasSeats,
        IHasTargetAudience,
        ITrainingCollection<Task_Q>
    {
        //TODO: can be defined as a collection of leader/critical steps on the owner's level (task/step)
        //This may simplify validations (only 5 leader steps)
        public bool IsLeader_Q { get; set; }
        public bool IsCritical_Q { get; set; }
        //TODO: Conditions: weather, etc

        public IReadOnlyCollection<AtisStep> Steps { get; set; }

        public EvaluationOutline EvaluationOutline_Q { get; }
        public PrerequisiteContainer Prerequisites_Q { get; }
        public ResourceRequirementsContainer ResourceRequirements_Q { get; }
        public SeatContainer Seats_Q { get; }
        public TargetAudienceContainer TargetAudience { get; }

        public IReadOnlyCollection<Task_Q> GetTrainingItems_Q()
        {
            //recursively get all steps. Handle duplicates is steps are sharable
            return Steps
                .Select(s => s.GetTrainingItems_Q())
                .SelectMany(s => s)
                .ToList();
        }
    }
}