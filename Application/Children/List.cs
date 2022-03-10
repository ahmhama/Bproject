using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Children
{
    public class List
    {
        public class Query : IRequest<List<Child>> {}

        public class Handler : IRequestHandler<Query, List<Child>>
        {
        private readonly DataContext _context;
            public Handler(DataContext context)
            {
            _context = context;
            }

            public async Task<List<Child>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Child.ToListAsync();
            }
        }
    }
}