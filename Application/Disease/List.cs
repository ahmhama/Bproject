using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Disease
{
    public class List
    {
        public class Query : IRequest<List<Diseases>> {}

        public class Handler : IRequestHandler<Query, List<Diseases>>
        {
        private readonly DataContext _context;
            public Handler(DataContext context)
            {
            _context = context;
            }

            public async Task<List<Diseases>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Diseases.ToListAsync();
            }
        }

    }
}