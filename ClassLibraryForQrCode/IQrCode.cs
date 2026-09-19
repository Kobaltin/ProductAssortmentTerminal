
namespace ClassLibraryForQrCode
{
    public interface IQrCode
    {
        public string getQrCodeInformation();//получение информации по коду в строковом виде
        public string getTextInformation();//полчение текста
        public void setNewText(string newText);//установка текста для кодирования
        public string getQR();//вывод кода по опредеелнному правилу

    }
}
