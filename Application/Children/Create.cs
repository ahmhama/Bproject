using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Children
{
    public class Create
    {
        public class Commnad : IRequest
        {
            public Child Child { get; set; }
        }

        public class Handler : IRequestHandler<Commnad>
        {
        private readonly DataContext _context;
            public Handler(DataContext context)
            {
            _context = context;
            }

            public async Task<Unit> Handle(Commnad request, CancellationToken cancellationToken)
            {
                _context.Child.Add(request.Child);
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}