namespace GeniyIdiot.Common
{
    public class InputValidator
    {
        public static bool TryParseToNumber(string input,out int number, out string errorMessage)
        {
            try
            {
                number = Convert.ToInt32(input);
                errorMessage = string.Empty;
                return true;
            }
            catch (FormatException)
            {

                errorMessage = "Пожалуйста, введите число!";
                number = 0;
                return false;
            }
            catch (OverflowException)
            {
                errorMessage = "Пожалуйста, введите число от -2*10^9 до 2*10^9";
                number = 0;
                return false;
            }
            
        }
    }
}
