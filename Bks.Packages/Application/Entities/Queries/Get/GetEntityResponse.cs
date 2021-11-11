﻿using System;
using Bks.Packages.Domain.Entities;

namespace Bks.Packages.Application.Entities.Queries.Get
{
    public abstract class GetEntityResponse
    {
        public Guid Id { get; }
        public string ExternalId { get; }
        public string Name { get; }
        public string Description { get; }

        protected GetEntityResponse(AggregateRoot entity)
        {
            Id = entity.Id;
            ExternalId = entity.ExternalId;
            Name = entity.Name;
            Description = entity.Description;
        }
    }
}