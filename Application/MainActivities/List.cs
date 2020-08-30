using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Data;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.MainActivities
{
    public class List
    {
        public class Query : IRequest<List<MainActivity>> { }
        public class Handler : IRequestHandler<Query, List<MainActivity>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;

            }

            public async Task<List<MainActivity>> Handle(Query request, CancellationToken cancellationToken)
            {
                var activities = await _context.MainActivities.ToListAsync();

                return activities;
            }
        }
    }
}