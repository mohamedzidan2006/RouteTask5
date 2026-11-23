namespace RouteTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            #region Q1
            //Console.WriteLine(book.password); //error 
            #endregion
            #region Q2
            //Console.WriteLine(book.copiesInStock); 
            #endregion
            #region Q3
            //book.Title = "C# basics";
            //Console.WriteLine(book.Title); 
            #endregion
            #region Q4
            //book.BookGenre = Genre.Science;
            //Console.WriteLine(book.BookGenre); 
            #endregion
            #region Q5
            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science); 
            #endregion
            #region Q6
            //int genreNumber = 1;
            //Genre g = (Genre)genreNumber;
            //Console.WriteLine(g); 
            #endregion
            #region Q7
            //Genre genre = Genre.Fiction;
            //string text = genre.ToString();
            //Console.WriteLine(text); 
            #endregion
            #region Q8
            //string genreText = "Science";
            //Genre g = (Genre)Enum.Parse(typeof(Genre), genreText);
            //Console.WriteLine(g); 
            #endregion
            #region Q9
            //string genreText = "Mystery";

            //if (Enum.TryParse(genreText, out Genre result))
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Unknown genre");
            //} 
            #endregion
        }
    }
}
