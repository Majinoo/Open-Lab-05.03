namespace Open_Lab_05._03
{
    public class Numbers
    {
        public string FormatNum(int num)
        {
            string number = num.ToString();
            if (num > 999 && num < 1000000)
            {
                number = number.Insert(number.Length - 3, ",");
                return number;
            }
            else if(num < 999)
            {
                return num.ToString();
            }
            else
            {
                return num.ToString("N0");
            }
        }
    }
}
