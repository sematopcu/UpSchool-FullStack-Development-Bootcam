using Application.Common.Interfaces;
using Application.Features.Addresses.Commands.Add;
using Domain.Common;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Addresses.Commands.Delete
{
    public class AddressDeleteCommandHandler : IRequestHandler<AddressDeleteCommand, Response<int>>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public AddressDeleteCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        async Task<Response<int>> IRequestHandler<AddressDeleteCommand, Response<int>>.Handle(AddressDeleteCommand request, CancellationToken cancellationToken)
        {
            var entity = await _applicationDbContext.Addresses
                .Where(x => x.Id == Guid.Parse(request.Id))
                .SingleOrDefaultAsync(cancellationToken);

            if (entity == null)
            {
                throw new Exception();
            }

            entity.IsDeleted = true;

            _applicationDbContext.Addresses.Update(entity);

            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return new();

        }
    }
}
