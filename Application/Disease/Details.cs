using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Disease
{
    public class Details
    {
        public class Query : IRequest<Diseases>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Diseases>
        {
        private readonly DataContext _context;
            public Handler(DataContext context)
            {
            _context = context;
            }

            public async Task<Diseases> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Diseases.FindAsync(request.Id);
            }
        }
    }
}