namespace GenericsExercise
{
    internal class GenericsExercise
    {
        static void Main(string[] args)
        {
            // varitac ganvixilavt Listitac
            List<Movies<double, DateTime>> firstList = new List<Movies<double, DateTime>>();
            var secondList = new List<Movies<float, int>>();

            var darkKnight1 = new Movies<float,int>();
            darkKnight1.MovieName = "Batman Begins";
            darkKnight1.Director = "Christopher Nolan";
            darkKnight1.Rate = 8.3f;
            darkKnight1.ReleaseDate = 2005;


            var darkKnight2 = new Movies<float, int>();
            darkKnight2.MovieName = "The Dark Knight";
            darkKnight2.Director = "Christopher Nolan";
            darkKnight2.Rate = 9.0f;
            darkKnight2.ReleaseDate = 2008;


            var darkKnight3 = new Movies<float, int>();
            darkKnight3.MovieName = "Dark Knight Rises";
            darkKnight3.Director = "Christopher Nolan";
            darkKnight3.Rate = 8.4f;
            darkKnight3.ReleaseDate = 2012;

            Movies<double,DateTime> lordOfTheRings1 = new Movies<double,DateTime>();
            lordOfTheRings1.MovieName = "Lord Of The Rings: The Fellowship Of The King";
            lordOfTheRings1.Director = "Peter Jackson";
            lordOfTheRings1.Rate = 8.8;
            lordOfTheRings1.ReleaseDate = new DateTime(2001, 12, 19);

            Movies<double, DateTime> lordOfTheRings2 = new Movies<double, DateTime>();
            lordOfTheRings2.MovieName = "Lord Of The Rings: The Two Towers";
            lordOfTheRings2.Director = "Peter Jackson";
            lordOfTheRings2.Rate = 8.7;
            lordOfTheRings2.ReleaseDate = new DateTime(2002, 12, 18);

            Movies<double, DateTime> lordOfTheRings3 = new Movies<double, DateTime>();
            lordOfTheRings3.MovieName = "Lord Of The Rings: The Return Of The King";
            lordOfTheRings3.Director = "Peter Jackson";
            lordOfTheRings3.Rate = 8.9;
            lordOfTheRings3.ReleaseDate = new DateTime(2003, 12, 17);

            firstList.Add(lordOfTheRings1);
            firstList.Add(lordOfTheRings2);
            firstList.Add(lordOfTheRings3);

            secondList.Add(darkKnight1);
            secondList.Add(darkKnight2);
            secondList.Add(darkKnight3);

            Console.WriteLine("Movies in first list:");

            foreach (var item in firstList)
            {
                Console.WriteLine($"Movie Name: {item.MovieName}");
                Console.WriteLine($"Director: {item.Director}");
                Console.WriteLine($"Rate: {item.Rate}");
                Console.WriteLine($"Release Date: {item.ReleaseDate}");
                Console.WriteLine();
            }

            Console.WriteLine("Movies in second list:");

            foreach (var item in secondList)
            {
                Console.WriteLine($"Movie Name: {item.MovieName}");
                Console.WriteLine($"Director: {item.Director}");
                Console.WriteLine($"Rate: {item.Rate}");
                Console.WriteLine($"Release Date: {item.ReleaseDate}");
                Console.WriteLine();
            }
        }
    }

    
    
    class Movies<T, U>
    {
        private string movieName;

        public string MovieName
        {
            get { return movieName; }
            set { movieName = value; }
        }

        private string director;

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        private U releaseDate;

        public U ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
            private T rate;
        public T Rate
        {
            get { return rate; }
            set { rate = value; }
        }
    }
}