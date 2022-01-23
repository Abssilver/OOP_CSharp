namespace OOP_Homework
{
    /*
    Определить интерфейс IСoder, который полагает методы поддержки шифрования строк. 
    В интерфейсе объявляются два метода Encode() и Decode(), используемые  для шифрования и дешифрования строк. 
    */
    public interface ICoder
    {
        string Encode(string toEncode);
        string Decode(string toDecode);
    }
}