using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssortimentFormationLibrary
{
    internal class Pacaging: Product
    {
        private IProduct product;
        public Pacaging(IProduct prod)
            : base(prod.Id, prod.Price * 1.1, prod.ProductName, new PackagingСodes())
        {
            this.product = prod;
        }
        string _type;
        public override string Type { get => $"Упаковка ({product.Type})"; }
        public override string Description {get => product.Description;}


    }
}
