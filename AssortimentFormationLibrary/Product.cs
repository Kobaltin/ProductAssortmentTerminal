using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryForQrCode;

namespace AssortimentFormationLibrary
{
    
    public abstract class Product:IProduct
    {
        /// <summary>
        /// агрегация
        /// </summary>
        private IQrCode qr;
        
        public string Code
        { 
            get 
            {
                return qr.Code;
            } 
            set 
            {
                qr.Text = value;
            }
        }
        /// <summary>
        /// Реализация свойства QR кода
        /// </summary> 
        private void putStringInQr(int id, double price) {
                Code = $"{id}:{price}";
        }
        /// <summary>
        /// Реализация свойства, характеризующее идентификатор
        /// </summary>
        private int _id;
        public virtual int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                putStringInQr(value, Price);
            }
        }
        /// <summary>
        /// Реализация свойства наимеенования продукта
        /// </summary>
        private double _price;
        public virtual double Price {
            get {
                return _price;
            }
            set {
                _price = value;
                putStringInQr(Id, value);
            } 
        }
        public string ProductName { get; private set; }
        /// <summary>
        /// Делаем свойство типа абстрактным
        /// </summary>

        public abstract string Type { get;}
        /// <summary>
        /// Делаем свойство описания абстрактным
        /// </summary>
        public abstract string Description { get;}
        /// <summary>
        /// Конструктор 
        /// </summary>
        protected Product(int id, double price, string productName, IQrCode qr1)
        {
            this.qr = qr1;
            Id = id;
            Price = price;
            ProductName = productName;
            putStringInQr(Id, Price);
        }
        /// <summary>
        /// Строковое представление
        /// </summary>
        public override string ToString()
        {
            return $"Тип товара:{Type}\nИмя товара:{ProductName}\nОписание:\n{Description}Код:\n{qr.ToString()}\n";
        }

        
    }
}
