﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Cities.Queries.GetAll;
using MediatR;

namespace Application.Features.Addresses.Queries.GetAll
{
    public class AddressGetAllQuery : IRequest<List<AddressGetAllDto>>
    {

        public string UserId { get; set; }
        public bool? IsDeleted { get; set; }

        public AddressGetAllQuery(string userId, bool? isDeleted)
        {
            UserId = userId;

            IsDeleted = isDeleted;
        }


    }
}
