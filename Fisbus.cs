namespace ConsoleApp4
{
    class Fisbus
    {
        public string ShowResult(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0))
                return "FISBUS";
            else if ((number % 3 == 0) && !(number % 5 == 0))
                return "FIS";
            else if (!(number % 3 == 0) && (number % 5 == 0))
                return "BUS";
            else
                return number.ToString();
        }
    }
}
