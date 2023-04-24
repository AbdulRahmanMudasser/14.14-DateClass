class Date
{
    // declaring variables
    public int month;
    public int day;
    public int year;

    // Month property for setting and getting value for month variable
    int Month
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
    Date (int month, int day, int year)
    {
        Month = month;
        Day = day;
        Year = year;
    }
}
