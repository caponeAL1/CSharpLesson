using LibraryA;

Book book = new Book();
book.Title = "American Prometheus";
book.Author = "Kai Bird, Martin J Sherwin";
book.Genre = "BioGraphy";
book.BookPrice = 800;
book.BookmarkPage(1000);
Console.WriteLine(book.GetCurrentPage());
Calculator calculator = new Calculator();
int addResult = calculator.Add(20, 70);
Console.WriteLine(addResult);
int MultiplyResult = calculator.Multiply(20, 20);
Console.WriteLine(MultiplyResult);
int DivideResult = calculator.Divide(20, 20);
Console.WriteLine(DivideResult);


