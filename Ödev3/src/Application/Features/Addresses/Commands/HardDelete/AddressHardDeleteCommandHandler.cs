using Application.Common.Interfaces;
using Application.Features.Addresses.Commands.Add;
using Application.Features.Addresses.Commands.Delete;
using Domain.Common;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Application.Features.Addresses.Commands.HardDelete
{
    public class AddressHardDeleteCommandHandler : IRequestHandler<AddressDeleteCommand, Response<int>>


    {


        private readonly IApplicationDbContext _applicationDbContext;

        public AddressHardDeleteCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<Response<int>> Handle(AddressDeleteCommand request, CancellationToken cancellationToken)
        {
            var entity = await _applicationDbContext.Addresses
                .Where(x => x.Id == Guid.Parse(request.Id))
                .SingleOrDefaultAsync(cancellationToken);

            if (entity == null)
            {
                throw new Exception();
            }

            _applicationDbContext.Addresses.Remove(entity);

            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return new();
        }
    }
}
