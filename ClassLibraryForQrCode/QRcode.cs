using System;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace ClassLibraryForQrCode
{
    public class QRcode: IQrCode
    {
        public static QrCodeType modeQrCode { get; set; }
        private string textForCoding;
        private QR qrCodeVersion = QR.V1;     
        private EccLevel? errCorelation; 
        private Mask? mask;             
        private string stringOfCode;

        public string getQR() => ToString();

        public string getQrCodeInformation()
        {
            return $"Версия QR кода: {qrCodeVersion}\nКорелляция ошибки: {errCorelation}\nМаска: {mask}\n";

        }
        public string getTextInformation()
        {
            return textForCoding;
        }

        public void setNewText(string newText)
        {
            textForCoding = newText;
            EncodingMode encodingMode = EncodingMode.Numeric;
            qrCodeVersion = QR.V1;
            errCorelation = default;
            mask = default;

            stringOfCode = textForCoding.ToQrCode(ref qrCodeVersion, ref encodingMode,ref errCorelation,ref mask);
        }
        
        public override string ToString()
        {
            switch (modeQrCode)
            {
                case QrCodeType.Text: return textForCoding; break;
                case QrCodeType.QrCode:return stringOfCode; break;
                case QrCodeType.Full:return $"{textForCoding}\n{stringOfCode}";break;
                default: return "Неизвестный формат текста";

            }
        }

        

    }
}


