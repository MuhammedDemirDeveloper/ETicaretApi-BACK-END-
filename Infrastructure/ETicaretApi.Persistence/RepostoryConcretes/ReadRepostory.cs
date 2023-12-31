﻿using ETicaretApi.Application.Repostories;
using ETicaretApi.Domain.Entities.Common;
using ETicaretApi.Persistence.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Persistence.RepostoryConcretes
{
    public class ReadRepostory<T> : IReadRepostory<T> where T : BaseEntity
    {
        private readonly ETicaretDbContext _context;

        public ReadRepostory(ETicaretDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
       => Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
       => Table.Where(method);
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
        => await Table.FirstOrDefaultAsync(method);

        public async Task<T> GetByIdAsync(string id)
       => await Table.FindAsync(Guid.Parse(id)); 

    }
}
