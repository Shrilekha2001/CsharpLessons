using FirstMVCApp.Models;
using Microsoft.AspNetCore.Authorization.Policy;
using System.Text;

namespace FirstMVCApp.Models
{
    public class AuthorRepository
    {
        public static Dictionary<int, Author> GetAuthorDictionary()
        {
            String fName = @"E:\temp\Author.csv";
            Dictionary<int, Author> list = new Dictionary<int, Author>();
            bool isFilExists = System.IO.File.Exists(fName);
            if (isFilExists)
            {
                using (StreamReader sr = new StreamReader(fName))
                {
                    string strAuthor = $"{sr.ReadLine()}";
                    String[] data = strAuthor.Split(',');
                    Author author = null;
                    if (data.Length == 5)
                    {
                        author = StringToAuthor(data, new Author());
                        list.Add(author.AuthorID, author);
                        while (!sr.EndOfStream)
                        {
                            strAuthor = $"{sr.ReadLine()}";
                            data = strAuthor.Split(',');
                            if (data.Length == 5)
                            {
                                author = StringToAuthor(data, new Author());
                                list.Add(author.AuthorID, author);
                            }
                        }
                    }




                }
            }
            return list;





        }
        private static Author StringToAuthor(String[] data, Author author)
        {

            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.AuthorDOB = DateTime.Parse(data[2]);
            author.AuthorRoyalty = data[4];
            author.Numberofbook = int.Parse(data[3]);
            return (author);
        }
        ////private static Author StringToAuthor(String[] data, Author author)





        public static Author FindAuthorById(int id)
        {
            Dictionary<int,Author>list =AuthorRepository.GetAuthorDictionary();
            Author author = null;
            if(list !=null)
            {
                author= list.FirstOrDefault(x =>(x.Key == id)).Value;
            }
            return author;
        }





        public static void SaveToFile(Author pAuthor)
        {
            String fName = @"E:\temp\Author.csv";
            string strAuthor = $"{pAuthor.AuthorID},{pAuthor.AuthorName},{pAuthor.AuthorRoyalty},{pAuthor.Numberofbook}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strAuthor);
            }

        }
        public static void UpdateAuthor(Author pauthor)
        {
            String fName = @"E:\temp\Author.csv";
            Dictionary<int,Author> list=AuthorRepository.GetAuthorDictionary(); 
            string strAuthor=string.Empty;
            using (StreamWriter sw=new StreamWriter(fName, true))
            {
                foreach (Author author in list.Values)
                {
                    if (author.AuthorID != pauthor.AuthorID)
                        strAuthor = $"{author.AuthorID},{author.AuthorName},{author.AuthorDOB},{author.Numberofbook},{author.AuthorRoyalty}";
                    else
                        strAuthor = $"{pauthor.AuthorID},{pauthor.AuthorName},{pauthor.AuthorDOB},{pauthor.Numberofbook},{pauthor.AuthorRoyalty}";
                    sw.WriteLine(strAuthor);

                }
            }
        }
        

        public static void RemoveAuthor(int id)

        {

            String fName = @"E:\temp\Author.csv";

            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();

            StringBuilder sbAuthor = new StringBuilder(list.Count +100);

            

                foreach (Author author in list.Values)

                {

                    if (author.AuthorID != id)

                    {

                        sbAuthor .Append( $"{author.AuthorID},{author.AuthorName},{author.AuthorDOB},{author.Numberofbook},{author.AuthorRoyalty}{Environment.NewLine}");

                        File.WriteAllText(fName,sbAuthor.ToString());

                    }

                }

            

        }
    }   
}