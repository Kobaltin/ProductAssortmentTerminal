namespace ClassLibraryForQrCode
{
    internal class QRcode
    {
        public static QrCodeType getModeQrCode {  get; set; }
        private string textForCoding { get; set; }
        private QR qrCodeVersion { get; set; }
        private EccLevel errCorelation { get; set; }
        private Mask mask { get; set; }
        private string stringOfCode { get; set; }


    }
}
