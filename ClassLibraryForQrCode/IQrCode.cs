
namespace ClassLibraryForQrCode
{
    public interface IQrCode
    {
        public static QrCodeType QrCodeTy { get; set; } = QrCodeType.Full; // Свойство, содержащее тип вывод QR
        string Text { get; set; }
        string Code { get; }


     

    }
}
