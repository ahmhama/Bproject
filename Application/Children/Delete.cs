using MediatR;
using Persistence;

namespace Application.Children
{
    public class Delete
    {
        public class Commnad : IRequest
        {
            public int Id { get; set; }
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
                var child = await _context.Child.FindAsync(request.Id);
                _context.Remove(child);
                await _context.SaveChangesAsync();
                return Unit.Value;
                
            }
        }
    }
}