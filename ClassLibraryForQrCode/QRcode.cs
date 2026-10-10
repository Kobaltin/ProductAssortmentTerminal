using System;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ClassLibraryForQrCode
{
    public class QRcode: IQrCode
    {
        private QR qrCodeVersion = QR.V1;

        private EccLevel? errCorelation;

        private Mask? mask;

        private EncodingMode mode;


        private string code;
        public string Code 
        {
            get 
            {
                return code;
            }
        }
        private string text;
        public string Text 
        {
            get 
            {
                return text;
            }
            set
            {
                if (text != value && value!=null)
                {
                    text = value;
                    code = value.ToQrCode(ref qrCodeVersion, ref mode, ref errCorelation, ref mask);
                }
            }
        }
        
        public override string ToString()
        {
            switch (IQrCode.QrCodeTy)
            {
                case QrCodeType.Text: return Text; break;
                case QrCodeType.QrCode:return Code; break;
                case QrCodeType.Full:return $"{Text}\n{Code}";break;
                default: return "Неизвестный формат текста";

            }
        }

        

    }
}


