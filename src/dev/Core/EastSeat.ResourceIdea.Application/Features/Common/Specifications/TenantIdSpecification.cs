﻿using EastSeat.ResourceIdea.Domain.Common.Entities;
using EastSeat.ResourceIdea.Domain.Tenants.ValueObjects;

using System.Linq.Expressions;

namespace EastSeat.ResourceIdea.Application.Features.Common.Specifications
{
    public class TenantIdSpecification<TEntity>(TenantId tenantId) : BaseSpecification<TEntity> where TEntity : BaseEntity
    {
        private readonly TenantId _tenantId = tenantId;

        public override Expression<Func<TEntity, bool>> Criteria => entity => entity.TenantId == _tenantId;
    }
}
