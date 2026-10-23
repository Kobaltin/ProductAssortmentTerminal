using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssortimentFormationLibrary
{
    internal interface IProduct
    {/// <summary>
        /// Публичное свойство идентификатора, позволяющее менять и возвращать значение идентификатора соответственно
        /// </summary>
        public int Id { get; set; } 
        
        public double Price { get; set; }
        /// <summary>
        /// Публичное свойство цены, позволяющее менять и возвращать значение цены соответственно
        /// </summary>
        public string ProductName { get; }
        /// <summary>
        /// Публичное свойство наименования продукта, возвращать значение имени продукта соответственно
        /// </summary>
        public string Code { get; }
        /// <summary>
        /// Публичное свойство QR кода, возвращать QR код соответственно
        /// </summary>
        public string Type { get; }
        /// <summary>
        /// Публичное свойство наименования продукта, возвращать тип объекта
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// Публичное свойство, характеризующее описание, возвращает тип объекта
        /// </summary>

    }
}
