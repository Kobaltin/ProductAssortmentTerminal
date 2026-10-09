// See https://aka.ms/new-console-template for more information
using ClassLibraryForQrCode;
using static System.Net.Mime.MediaTypeNames;

QRcode qr = new QRcode();
qr.setNewText("Solovev Zakhar Andreevich 76548976845764857638764389673487634!!!!!!!!!!!!!!!!NN!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
QRcode.modeQrCode = QrCodeType.Full;
Console.WriteLine(qr.ToString());
Console.WriteLine(qr.getQrCodeInformation());
qr.setNewText("Fish");
Console.WriteLine(qr.ToString());
Console.WriteLine(qr.getQrCodeInformation());
