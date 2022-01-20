namespace OOP_Homework
{
    internal static class StringRevertUtil
    {
        public static string GetRevertString(string toRevert)
        {
            var buffer = new char[toRevert.Length];
            for (var i = 0; i < toRevert.Length; i++)
            {
                buffer[i] = toRevert[toRevert.Length - 1 - i];
            }

            return new string(buffer);
        }
    }
}