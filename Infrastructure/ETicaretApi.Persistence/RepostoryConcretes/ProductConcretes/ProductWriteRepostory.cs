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
    public class ProductWriteRepostory : WriteRepostory<Product>, IProductWriteRepostory
    {
        public ProductWriteRepostory(ETicaretDbContext context) : base(context)
        {
        }
    }
}
