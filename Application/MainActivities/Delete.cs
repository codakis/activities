using System;
using System.Threading;
using System.Threading.Tasks;
using Data;
using MediatR;

namespace Application.MainActivities
{
    public class Delete
    {
        public class Command : IRequest
        {
            //object properties goes here
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                //object creation and mapping here 
                var activity = await _context.MainActivities.FindAsync(request.Id);

                if (activity == null)
                    throw new Exception("Could not find main activity");

                _context.Remove(activity);

                var success = await _context.SaveChangesAsync() > 0;

                if (success) return Unit.Value;

                throw new Exception("Problem saving changes");
            }
        }
    }
}