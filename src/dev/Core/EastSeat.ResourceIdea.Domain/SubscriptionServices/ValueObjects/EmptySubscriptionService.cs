﻿using EastSeat.ResourceIdea.Domain.SubscriptionServices.Entities;

namespace EastSeat.ResourceIdea.Domain.SubscriptionServices.ValueObjects;

public sealed record EmptySubscriptionService
{
    public static SubscriptionService Instance { get; } = new()
    {
        Id = SubscriptionServiceId.Create(Guid.Empty),
        Name = string.Empty
    };

    private EmptySubscriptionService() { }
}
