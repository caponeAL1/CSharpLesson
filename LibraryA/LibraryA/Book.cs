namespace LibraryA
{
    public class Book
    {
        public String Title = String.Empty;
        public String Author = String.Empty;
        public String Genre = String.Empty;
        public int BookPrice;
        public int TotalPages = 300;
        public Book()
        {
            Console.WriteLine("Book obj is Created");
        }
        public void OpenBook()
        {
            Console.WriteLine("Book is Open");
        }
        public void BookmarkPage(int PageNo)
        {
            Console.WriteLine($"Page No:{PageNo}BookMarked");
        }
        public int GetCurrentPage()
        {
            Random rand = new Random();
            return rand .Next( TotalPages );
        }
    }
}