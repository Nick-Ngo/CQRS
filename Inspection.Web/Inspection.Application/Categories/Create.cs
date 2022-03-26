using Inspection.Domain;
using Inspection.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inspection.Application.Categories
{
    public class Create
    {
        public class Command : IRequest
        {
            public Category Category { get; set; }
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
                request.Category.Id = Guid.NewGuid();
                _context.Categories.Add(request.Category);
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}
