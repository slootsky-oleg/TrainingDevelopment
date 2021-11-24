﻿using System;
using System.Collections.Generic;
using System.Linq;
using Bks.Packages.Core.Domain.Values.Ids;

namespace Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements
{
    public static class ResourceRequirementExtension
    {
        public static T GetRequired<T>(this IReadOnlyCollection<T> requirements, GuidId id)
            where T : ResourceRequirement
        {
            return requirements.SingleOrDefault(r => r.Id == id)
                   //TODO: replace with a concrete exception
                   ?? throw new Exception($"Requirement [{id}] not found.");
        }
    }
}