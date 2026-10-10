// See https://aka.ms/new-console-template for more information
using ClassLibraryForQrCode;
using static System.Net.Mime.MediaTypeNames;

QRcode qr = new QRcode();
qr.Text = Console.ReadLine();
Console.WriteLine(qr);
