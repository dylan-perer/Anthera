namespace Anthera_API.Data
{
    public static class ConstantMapper
    {
        public static int StringToByte(string value, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (value.ToLower().Equals(array[i].ToLower()))
                {
                    return i + 1;
                }
            }
            return 1;
        }

        public static string ByteToString(byte value, string[] array)
        {
            return array[value];
        }
    }
}
