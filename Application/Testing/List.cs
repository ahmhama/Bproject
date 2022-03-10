using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Testings
{
    public class List
    {
        public class Query :IRequest<List<Testing>> {}

        public class Handler : IRequestHandler<Query, List<Testing>>
        {
        private readonly DataContext _conext;
            public Handler(DataContext conext)
            {
            _conext = conext;
            }

            public async Task<List<Testing>> Handle(Query request, CancellationToken cancellationToken)
            {
              return  await _conext.Testing.ToListAsync();
            }
        }


    }
}