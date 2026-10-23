
namespace ClassLibraryForQrCode
{
    public interface IQrCode
    {
        public static QrCodeType QrCodeTy { get; set; }
        string Text { get; set; }
        string Code { get; }


     

    }
}
