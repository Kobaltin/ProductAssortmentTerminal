using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryForQrCode;

namespace AssortimentFormationLibrary
{
    internal class ElectricMotor:Product
    {
        public double PowerKw { get; set; }
        public double VoltageV { get; set; }
        public override string Type { get => "Электрический мотор";}
        private string _description;
        public override string Description { get => $"Мощность:{PowerKw}\nНапряжение:{VoltageV}\n"; }
        public ElectricMotor(int id, double price, string productName, double power, double voltage)
            : base( id, price,productName, new QRcode())
        {
            PowerKw = power;
            VoltageV = voltage;
        }
    }
}
