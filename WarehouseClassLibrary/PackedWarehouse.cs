using AssortimentFormationLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseClassLibrary
{
    internal class PackedWarehouse<T> : Warehouse<T> where T : class, IProduct
    {
        /// <summary>
        /// закрытый конструктор
        /// </summary>
        private PackedWarehouse((int size, int ?id) parametrs) 
            :base(data.size, data.id)
        {
        }
    }
}