namespace Anthera_API.Contracts.v1.Requests
{
    public abstract class Request
    {
        protected int StringToByte(string gender, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (gender.ToLower().Equals(array[i].ToLower()))
                {
                    return i + 1;
                }
            }
            return 1;
        }

    }
}
