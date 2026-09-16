
namespace ClassLibraryForQrCode
{
    public interface IQrCode
    {
        public (Mask, EccLevel, QR) getQrCodeInformation();
        public string getTextInformation();
        public void setNewText(string newText);
        public string getQR();

    }
}
