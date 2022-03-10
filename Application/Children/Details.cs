using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Children
{
    public class Details
    {
        public class Query : IRequest<Child>
        {
            public int Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, Child>
        {
        private readonly DataContext _context;
            public Handler(DataContext context)
            {
            _context = context;
            }

            public async Task<Child> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Child.FindAsync(request.Id);
            }
        }
    }
}