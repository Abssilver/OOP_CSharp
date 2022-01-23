using System;
using System.Linq;

namespace OOP_Homework
{
    /*
    Создать класс ACoder, реализующий интерфейс ICoder. 
    Класс шифрует строку посредством сдвига каждого символа на одну «алфавитную» позицию выше. 
    (В результате такого сдвига буква А становится буквой Б). 
    */
    internal sealed class ACoder: ICoder
    {
        private readonly int _firstCharLowerInt;
        private readonly int _lastCharLowerInt;
        

        private const int EncryptionKey = 1;
        private const int DecryptionKey = -1; 
        

        public ACoder(char alphabetCharFirst, char alphabetCharLast)
        {
            _firstCharLowerInt = (int)Char.ToLowerInvariant(alphabetCharFirst);
            _lastCharLowerInt = (int)Char.ToLowerInvariant(alphabetCharLast);
        }

        public string Encode(string toEncode)
        {
            return new string(toEncode.Select(x => GetShiftedChar(x, EncryptionKey)).ToArray());
        }

        public string Decode(string toDecode)
        {
            return new string(toDecode.Select(x => GetShiftedChar(x, DecryptionKey)).ToArray());
        }

        private Char GetShiftedChar(char origin, int key)
        {
            var isUpper = Char.IsUpper(origin);
            var originToLowerInt = (int)Char.ToLowerInvariant(origin);

            if (originToLowerInt < _firstCharLowerInt || originToLowerInt > _lastCharLowerInt)
                throw new Exception("Unhandled char");

            var result = originToLowerInt + key;
            
            if (key < 0 && result < _firstCharLowerInt)
            {
                var limit = originToLowerInt -  _firstCharLowerInt;
                var difference = key + limit;
                result = _lastCharLowerInt + difference + 1;
            }
            else if (key > 0 && result > _lastCharLowerInt)
            {
                var limit = _lastCharLowerInt - originToLowerInt;
                var difference = key - limit;
                result = _firstCharLowerInt + difference - 1;
            }

            return isUpper
                ? Char.ToUpperInvariant((char)result)
                : (char)result;
        }
    }
}