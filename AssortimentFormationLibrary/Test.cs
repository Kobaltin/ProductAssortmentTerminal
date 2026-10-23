using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryForQrCode;

namespace AssortimentFormationLibrary
{
    public class TestLab1
    {
        public static void Test()
        {
            Console.Clear();
            Console.WriteLine("Лабораторная работа 2");

            IQrCode.QrCodeTy = QrCodeType.Full;
            
            IProduct motor = new ElectricMotor(1,20000, "NGH-123",1000,220);
            IProduct pacmotor = new Pacaging(motor);
            IProduct[] products = [motor, pacmotor];
            foreach (var prdct in products) {
                Console.WriteLine(prdct);
                prdct.Id++;
                prdct.Price+=1;
                Console.WriteLine(prdct);

            }
            Console.ReadKey();
        }

    }
}
