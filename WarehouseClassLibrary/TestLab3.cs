using AssortimentFormationLibrary;
using ClassLibraryForQrCode;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseClassLibrary
{
    public class TestLab3
    {
        public static void Test()
        {
            Console.Clear();
            Console.WriteLine("Лабораторная работа 3");
            IQrCode.QrCodeTy = QrCodeType.Full;
            IProduct motor1 = new ElectricMotor(1, 20000, "HCD12", 1000, 220);
            var motor2 = new Pacaging(new ElectricMotor(2, 23000, "HCD11", 12000, 220));
            IWarehouse<IProduct> assortiment1 = (Warehouse<IProduct>)2;
            IWarehouse<Pacaging> assortiment2 = (Warehouse<Pacaging>)1;
            assortiment1[0] = motor1;
            assortiment1.Push(motor2);
            assortiment1.OrderByName();
            Console.WriteLine("ЭТАП 1\n" + assortiment1.ToString());
            assortiment1.Id = 100;
            Console.WriteLine("ЭТАП 2\n" + assortiment1.ToString());
            var package = assortiment1[assortiment1.Find(motor2.Id)];
            assortiment2[0] = (Pacaging)package;
            Console.WriteLine("ЭТАП 3\n" + assortiment1.ToString());
            Console.WriteLine("ЭТАП 4\n" + assortiment2.ToString());


        }
    }
}
