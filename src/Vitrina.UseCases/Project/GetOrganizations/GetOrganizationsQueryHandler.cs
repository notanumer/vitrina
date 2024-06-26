﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Vitrina.Infrastructure.Abstractions.Interfaces;

namespace Vitrina.UseCases.Project.GetOrganizations;

/// <summary>
/// Get organizations handler.
/// </summary>
internal class GetOrganizationsQueryHandler : IRequestHandler<GetOrganizationsQuery, ICollection<string>>
{
    private readonly IAppDbContext dbContext;

    public GetOrganizationsQueryHandler(IAppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<ICollection<string>> Handle(GetOrganizationsQuery request, CancellationToken cancellationToken)
        => await dbContext.Projects.Where(p => p.Client != null).Select(p => p.Client!).Distinct().ToListAsync(cancellationToken);
}
