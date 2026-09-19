// See https://aka.ms/new-console-template for more information
using ClassLibraryForQrCode;
using static System.Net.Mime.MediaTypeNames;

QRcode qr = new QRcode();
qr.setNewText("Helo World!");
QRcode.modeQrCode = QrCodeType.Full;
Console.WriteLine(qr.ToString());

