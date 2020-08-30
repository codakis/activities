using System;
using Domain;
using MediatR;
using Data;
using System.Threading.Tasks;
using System.Threading;

namespace Application.MainActivities
{
    public class Details
    {
        public class Query : IRequest<MainActivity>
        {
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, MainActivity>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<MainActivity> Handle(Query request, CancellationToken cancellationToken)
            {
                var activity = await _context.MainActivities.FindAsync(request.Id);
                return activity;
            }
        }
    }
}