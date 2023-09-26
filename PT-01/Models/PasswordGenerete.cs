namespace PT_01.Models
{
    public class PasswordGenerete
    {
        #region Password Generation types

        private int _passwordNumber = default;
        private char[] _passwordCharecter = new char[default];
        private char[] _passwordSymbole = new char[default];
        private readonly int _passwordLength = default(Int32);
        private static int _lengthArray = default;
        private string generationPassword = string.Empty;

        #endregion

        int PasswordLength { set => _lengthArray = value; }

        public PasswordGenerete(int passwordLength)
        {
            PasswordLength = passwordLength;
        }


        public string PasswordGeneration(bool successNumber, bool successCharacter, bool successSymbole)
        {
            if (successNumber == true && successCharacter == true && successSymbole == true)
            {

            }



            return generationPassword;
        }






    }
}
