using System;
using System.Reflection.Emit;

namespace ClassLibraryForQrCode
{
    public class QRcode: IQrCode
    {
        public static QrCodeType modeQrCode;
        private string textForCoding;
        private QR qrCodeVersion;     
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
            stringOfCode = QrCodeMagicBuilder.ToQrCode(
                textForCoding,
                ref qrCodeVersion,
                ref encodingMode,
                ref errCorelation,
                ref mask);
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


