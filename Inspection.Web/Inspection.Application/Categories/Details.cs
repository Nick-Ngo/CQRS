﻿using Inspection.Domain;
using Inspection.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inspection.Application.Categories
{
    public class Details
    {
        public class Query : IRequest<Category>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Category>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Category> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Categories.FindAsync(request.Id);
            }
        }
    }
}
