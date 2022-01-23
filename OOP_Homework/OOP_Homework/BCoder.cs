using System;
using System.Linq;

namespace OOP_Homework
{
    /*
    Создать класс BCoder, реализующий интерфейс ICoder. 
    Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й позиции, на букву того же регистра,
    расположенную в алфавите на i-й позиции с конца алфавита. (Например, буква В заменяется на букву Э.
    */
    internal sealed class BCoder: ICoder
    {
        private readonly int _firstCharLowerInt;
        private readonly int _lastCharLowerInt;

        public BCoder(char alphabetCharFirst, char alphabetCharLast)
        {
            _firstCharLowerInt = (int)Char.ToLowerInvariant(alphabetCharFirst);
            _lastCharLowerInt = (int)Char.ToLowerInvariant(alphabetCharLast);
        }

        public string Encode(string toEncode)
        {
            return new string(toEncode.Select(GetShiftedChar).ToArray());
        }

        public string Decode(string toDecode)
        {
            return new string(toDecode.Select(GetShiftedChar).ToArray());
        }

        private Char GetShiftedChar(char origin)
        {
            var isUpper = Char.IsUpper(origin);
            var originToLowerInt = (int)Char.ToLowerInvariant(origin);
            var charIndex = originToLowerInt - _firstCharLowerInt;

            if (originToLowerInt < _firstCharLowerInt || originToLowerInt > _lastCharLowerInt)
                throw new Exception("Unhandled char");

            var result = _lastCharLowerInt - charIndex;

            return isUpper
                ? Char.ToUpperInvariant((char)result)
                : (char)result;
        }
    }
}