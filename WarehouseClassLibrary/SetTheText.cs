using AssortimentFormationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseClassLibrary
{
    static class SetTheText
        {/// <summary>
         /// Метод расширения, меняющий строковое представение зная индекс склада и номер позиуции
         /// </summary>
        public static void setText(this IProduct product, int wareHouseId, int wareHousePos) {
            product.Code = $"{wareHouseId}[{wareHousePos}]:({product.Id}:{product.Price})";
        }
        /// <summary>
        /// Метод расширения, меняющий строковое представение зная склад
        /// </summary>
        public static void setText<T>(this IProduct product, IWarehouse<T> wh) where T:class, IProduct
        {
            int position = wh.Find(product.Id);
            if(position >= 0)
            {
                product.setText(wh.Id, position);
            } 
        }
    }
}
