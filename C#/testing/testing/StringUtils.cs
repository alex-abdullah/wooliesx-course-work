using System;
namespace StringUtils
{
    public class StringUtils
    {
        public StringUtils()
        {
        }

        public static string Reverse(string text)
        {
            if (text == "")
                throw new Exception("String is Empty");

            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

        }

        
    }
}
