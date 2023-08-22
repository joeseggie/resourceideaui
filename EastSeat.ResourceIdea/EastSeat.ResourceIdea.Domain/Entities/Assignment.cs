﻿using EastSeat.ResourceIdea.Domain.Common;
using EastSeat.ResourceIdea.Domain.Constants;

namespace EastSeat.ResourceIdea.Domain.Entities;

/// <summary>
/// Engagement assignment.
/// </summary>
public class Assignment : BaseSubscriptionEntity
{
    /// <summary>
    /// Assignment Id.
    /// </summary>
    public Guid Id { get; set; } = Guid.Empty;

    /// <summary>
    /// Engagement that is being assigned to.
    /// </summary>
    public Guid? EngagementId { get; set; }

    /// <summary>Date when the assignment was started.</summary>
    public DateTime? StartDate { get; set; }

    /// <summary>Date when the assignment was closed.</summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Status of the assignment.
    /// </summary>
    public AssignmentStatus? Status { get; set; }

    /// <summary>Engagement where that assignment is added.</summary>
    public Engagement? Engagement { get; set; }

    /// <summary>Subscription to which the assignment belongs.</summary>
    public Subscription? Subscription { get; set; }
}
