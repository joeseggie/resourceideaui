using EastSeat.ResourceIdea.Application.Features.Common.Specifications;
using EastSeat.ResourceIdea.Application.Features.Common.ValueObjects;
using EastSeat.ResourceIdea.Application.Features.Engagements.Contracts;
using EastSeat.ResourceIdea.Application.Features.Engagements.Queries;
using EastSeat.ResourceIdea.Application.Mappers;
using EastSeat.ResourceIdea.Application.Types;
using EastSeat.ResourceIdea.Domain.Engagements.Entities;
using EastSeat.ResourceIdea.Domain.Engagements.Models;

using MediatR;

namespace EastSeat.ResourceIdea.Application.Features.Engagements.Handlers;

public class GetAllEngagementsQueryHandler(IEngagementsService engagementsService)
    : IRequestHandler<GetAllEngagementsQuery, ResourceIdeaResponse<PagedListResponse<EngagementModel>>>
{
    private readonly IEngagementsService _engagementsService = engagementsService;

    public async Task<ResourceIdeaResponse<PagedListResponse<EngagementModel>>> Handle(GetAllEngagementsQuery request, CancellationToken cancellationToken)
    {
        var result = await _engagementsService.GetPagedListAsync(
            request.PageNumber,
            request.PageSize,
            Optional<BaseSpecification<Engagement>>.None,
            cancellationToken);
        if (result.IsFailure)
        {
            return ResourceIdeaResponse<PagedListResponse<EngagementModel>>.Failure(result.Error);
        }

        if (result.Content.HasValue is false)
        {
            return ResourceIdeaResponse<PagedListResponse<EngagementModel>>.NotFound();
        }

        return result.Content.Value.ToResourceIdeaResponse();
    }
}