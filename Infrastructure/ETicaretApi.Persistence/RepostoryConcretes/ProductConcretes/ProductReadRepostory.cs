using ETicaretApi.Application.Repostories.ProductRepostory;
using ETicaretApi.Domain.Entities;
using ETicaretApi.Persistence.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Persistence.RepostoryConcretes.ProductConcretes
{
    public class ProductReadRepostory : ReadRepostory<Product>, IProductReadRepostory
    {
        public ProductReadRepostory(ETicaretDbContext context) : base(context)
        {
        }
    }
}
