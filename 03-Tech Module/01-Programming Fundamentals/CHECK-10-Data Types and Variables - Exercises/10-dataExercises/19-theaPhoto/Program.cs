using System;

namespace _19_theaPhoto
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfPictures = long.Parse(Console.ReadLine());
            long filterTimePerPicture = long.Parse(Console.ReadLine());
            double percentOfPicturesToUpload = double.Parse(Console.ReadLine());
            long uploadTimePerFilteredPicture = long.Parse(Console.ReadLine());


            long timeForFiltering = filterTimePerPicture * numberOfPictures;
            percentOfPicturesToUpload /= 100.0;
            double picturesToUpload = Math.Ceiling(numberOfPictures * percentOfPicturesToUpload);
            long timeForUpload = (long)picturesToUpload * uploadTimePerFilteredPicture;


            long allTimeInSec = timeForFiltering + timeForUpload;



            TimeSpan time = TimeSpan.FromSeconds(allTimeInSec);

            Console.WriteLine(time.ToString(@"d\:hh\:mm\:ss"));


        }
    }
}