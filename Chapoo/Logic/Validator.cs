namespace Chapoo.Logic
{
    public static class Validator
    {
        public static bool CheckCredentials(string text)
        {
            char[] letters = text.ToCharArray();
            string AllowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890 .?!";

            text = text.Replace("  ", " ");
            
            for (int i = 0; i < letters.Length; i++)
            {
                if (!AllowedChars.Contains(letters[i].ToString()))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
