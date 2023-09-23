namespace LibraryA
{
    public class Class1
    {
        public String Title=String.Empty;
        public String  Author=String.Empty;
        public String Genre=String.Empty;
        public DateTime DateOfPublish;
        public int Bookprice;
        public int TotalPage=300;

        public void OpenBook()
        {
            Console.WriteLine("Book is Open");

        }
        public void BookmarkPage(int pageno)
        {
            Console.WriteLine($"pageNO:{pageno} Bookmark");
                }
        public int GetCurrentPage() 
        {
            Random r= new Random();
            return r.Next(TotalPage); 
        }


    }
}