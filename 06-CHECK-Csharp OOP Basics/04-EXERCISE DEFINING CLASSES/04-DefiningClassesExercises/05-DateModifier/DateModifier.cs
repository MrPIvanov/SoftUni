using System;
using System.Globalization;

public class DateModifier
{
    public int CalculateDifrence(string firstDate, string lastDate)
    {
        var start = new DateTime();
        start = DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);

        var end = new DateTime();
        end = DateTime.ParseExact(lastDate, "yyyy MM dd", CultureInfo.InvariantCulture);

        int difrence = (int)(end - start).TotalDays;


        return difrence;
    }
}