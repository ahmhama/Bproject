using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Children
{
    public class Edit
    {
        public class Commnad : IRequest
        {
            public Child Child { get; set; }
        }

        public class Handler : IRequestHandler<Commnad>
        {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
            public Handler(DataContext context,IMapper mapper )
            {
            _context = context;
            _mapper = mapper;
            }

            public async Task<Unit> Handle(Commnad request, CancellationToken cancellationToken)
            {
                var child = await _context.Child.FindAsync(request.Child.ChildId);
                _mapper.Map(request.Child,child);
                await _context.SaveChangesAsync();
                return Unit.Value;

            }
        }
    }
}
