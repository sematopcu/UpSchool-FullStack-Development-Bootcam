using Domain.Common;
using Domain.Entities;
using Domain.Enums;
using Domain.Identity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Addresses.Commands.HardDelete
{
    public class AdressHardDeleteCommand: IRequest<Response<int>>
    {
        public string Id { get; set; }
    }
}
