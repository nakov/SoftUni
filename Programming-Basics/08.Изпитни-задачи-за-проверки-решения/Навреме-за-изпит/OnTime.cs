using System;

class OnTime
{
    //5.*Навреме за изпит
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int hArrived = int.Parse(Console.ReadLine());
        int mArrived = int.Parse(Console.ReadLine());

        DateTime time = DateTime.Parse(h + ":" + m);
        DateTime timeArrived = DateTime.Parse(hArrived + ":" + mArrived);
        DateTime difference;

        if (time.TimeOfDay < timeArrived.TimeOfDay) // if late
        {
            difference = timeArrived;
            difference = difference.AddHours(-h);
            difference = difference.AddMinutes(-m);

            Console.WriteLine("Late");

            if (difference.ToString("hh") != "12")
                Console.WriteLine("{0} hours after the start", difference.ToString("h:mm"));
            else
                Console.WriteLine("{0} minutes after the start", difference.Minute);
        }
        else if (time.TimeOfDay == timeArrived.TimeOfDay) // if on time 
        {
            Console.WriteLine("On time");
        }
        else if (timeArrived.AddMinutes(30) >= time) // if early
        {
            difference = time;
            difference = difference.AddHours(-hArrived);
            difference = difference.AddMinutes(-mArrived);

            Console.WriteLine("On time");

            if (difference.ToString("hh") != "12")
                Console.WriteLine("{0} hours before the start", difference.ToString("h:mm"));
            else
                Console.WriteLine("{0} minutes before the start", difference.Minute);
        }
        else // if too early
        {
            difference = time;
            difference = difference.AddHours(-hArrived);
            difference = difference.AddMinutes(-mArrived);

            Console.WriteLine("Early");

            if (difference.ToString("hh") != "12")
                Console.WriteLine("{0} hours before the start", difference.ToString("h:mm"));
            else
                Console.WriteLine("{0} minutes before the start", difference.Minute);
        }
    }
}

