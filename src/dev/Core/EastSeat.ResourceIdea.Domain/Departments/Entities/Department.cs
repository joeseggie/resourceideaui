﻿using EastSeat.ResourceIdea.Domain.Common.Entities;
using EastSeat.ResourceIdea.Domain.Departments.Models;
using EastSeat.ResourceIdea.Domain.Departments.ValueObjects;
using EastSeat.ResourceIdea.Domain.Types;

namespace EastSeat.ResourceIdea.Domain.Departments.Entities;

public class Department : BaseEntity
{
    /// <summary>
    /// Department ID.
    /// </summary>
    public DepartmentId Id { get; set; }

    /// <summary>
    /// Department name.
    /// </summary>
    public required string Name { get; set; }

    public override TModel ToModel<TModel>()
    {
        return (TModel)(object)new DepartmentModel
        {
            DepartmentId = Id,
            Name = Name,
            TenantId = TenantId
        };
    }

    public override ResourceIdeaResponse<TModel> ToResourceIdeaResponse<TEntity, TModel>()
    {
        throw new NotImplementedException();
    }
}
