using ClassLibraryForQrCode;
namespace AssortimentFormationLibrary
{
    public class PackagingСodes : IQrCode
    {
        private QRcode codeForPackaging = new QRcode();
        public string Code{ get; private set; }
        private string text;
        public string Text
        { 
            get 
            {
                return text;
            
            }
            set 
            {
                text = value;
                codeForPackaging.Text = value;
                Code = codeForPackaging.Code;
            }
        }
        public override string ToString()
        {
            switch (IQrCode.QrCodeTy)
            {
                case QrCodeType.Text: return "*"+Text+"*"; break;
                case QrCodeType.QrCode:return Code; break;
                case QrCodeType.Full:return $"*{Text}*\n{Code}";break;
                default: return "Неизвестный формат текста";

            }
        }
        

    }
}
