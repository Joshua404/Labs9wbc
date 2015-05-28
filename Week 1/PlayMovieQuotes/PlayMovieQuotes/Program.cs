using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace PlayMovieQuotes
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            var rnd = new Random();
//            var ms = rnd.Next(3);
//            var quote1 = 0;

//            string."quote1" = quote1;

//            var quotes = new String[] {
//            "quote1", "quote2", "quote3"
//            };

//            var quote1 = new System.Media.SoundPlayer();
//            quote1.SoundLocation = @"";
//            quote1.Play();

//            var quote2 = new System.Media.SoundPlayer();
//            quote2.SoundLocation = @"";
//            quote2.Play();

//            var quote3 = new System.Media.SoundPlayer();
//            quote3.SoundLocation = @"";
//            quote3.Play();


//            Console.WriteLine(quotes[ms]);
//            Console.ReadLine();

//    }

//        private static string quote1()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}


namespace PlayMovieQuotes
{
    class Program
    {
        static void Main(string[] args)
        {

            //var rnd = new Random();
            //var ms = rnd.Next(3);

            Random rnd = new Random();
            int choices = rnd.Next(1, 4);

            // set up your sound player here
            var hir = new string[] {
                @"http://www.wavsource.com/snds_2015-05-24_3842437052126496/movie_stars/schwarzenegger/conan_best_in_life.wav",
                @"http://www.wavsource.com/snds_2015-05-24_3842437052126496/movies/misc/shrek_on_the_road_z.wav",
                @"http://www.wavsource.com/snds_2015-05-24_3842437052126496/movie_stars/murphy/be_cool.wav"
            };






            try
            {
                // code to try here
                // playing the files on the internet
                switch (choices)
                {
                    case 1:
                        System.Media.SoundPlayer quote = new System.Media.SoundPlayer(hir[0]);
                        quote.PlaySync();
                        break;
                    case 2:
                        System.Media.SoundPlayer quote1 = new System.Media.SoundPlayer(hir[1]);
                        quote1.PlaySync();
                        break;
                    case 3:
                        System.Media.SoundPlayer quote2 = new System.Media.SoundPlayer(hir[2]);
                        quote2.PlaySync();
                        break;
                }
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    // code to execute instead
                    // play the files, set the source path to "/Content/whatever.wav"
                    System.Media.SoundPlayer error = new System.Media.SoundPlayer(@"C:\Users\Joshua\Dropbox\Coding School\9Week Bootcamp\Week 1\PlayMovieQuotes\PlayMovieQuotes\Content\pluck.wav");
                    error.PlaySync();
                }
            }

            //Console.WriteLine(rnd.Next);
            Console.ReadLine();

        }

    }

}
