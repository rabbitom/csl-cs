using System;

namespace Net.Erabbit.CSL
{
    public class CSLUtility
    {
        public CSLUtility()
        {
        }

        public static int ToIntLE(byte[] buffer, int offset = 0, int length = -1)
        {
            if (length == -1)
                length = buffer.Length - offset;
            int result = 0;
            for (var i = length - 1; i >= 0; i--)
            {
                result = result * 0x100 + buffer[offset + i];
            }
            return result;
        }

        public static void WriteIntLE(int value, byte[] array, int offset, int length)
        {
            for (var i = 0; i < length; i++)
                array[offset + i] = (byte)((value >> (8 * i)) & 0xff);
        }

        public static int ToIntBE(byte[] buffer, int offset = 0, int length = -1)
        {
            if (length == -1)
                length = buffer.Length - offset;
            var result = 0;
            for (var i = 0; i < length; i++)
            {
                result = result * 0x100 + buffer[offset + i];
            }
            return result;
        }

        public static void WriteIntBE(int value, byte[] array, int offset, int length)
        {
            for (var i = 0; i < length; i++)
                array[offset + (length - 1 - i)] = (byte)((value >> (8 * i)) & 0xff);
        }

        public static String ToHexString(byte[] buffer, int offset, int length = -1, String glue = "")
        {
            if (length == -1)
                length = buffer.Length - offset;
            String[] strs = new string[length];
            for (var i = 0; i < length; i++)
            {
                byte n = buffer[offset + i];
                strs[i] = String.Format("{0,2:X2}", n);
            }
            return String.Join(glue, strs);
        }
    }
}
