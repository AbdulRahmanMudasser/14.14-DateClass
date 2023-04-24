class Date
{
    // declaring variables
    private int month;
    private int day;
    private int year;

    // Month property for setting and getting value for month variable
    public int Month
    {
        get { return month; }
        set { month = value; }
    }

    // Day property for setting and getting value for day variable
    int Day
    {
        get { return day; }
        set { day = value; }
    }

    // Year property for setting and getting value for year variable
    int Year
    {
        get { return year; }
        set { year = value; }
    }

    // constructor
    public Date (int month, int day, int year)
    {
        Month = month;
        Day = day;
        Year = year;
    }

    // DisplayDate method
    public void DisplayDate()
    {
        Console.WriteLine("{0}/{1}/{2}", Month, Day, Year);
    }
}
// end of Date class

class DateTest
{
    static void Main(string[] args)
    {
        Date date = new Date(4, 24, 2023);

        date.DisplayDate();
    }
}
