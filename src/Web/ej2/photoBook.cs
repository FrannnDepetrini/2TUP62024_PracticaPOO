
namespace Web.ej2
{
    public class PhotoBook
    {
        public static int idGenerated = 0;
        protected int pages { get; private set; }
        public int id { get; set; }

        public PhotoBook()
        {
            pages = 16;
            id = idGenerated++;
        }

        //Otra forma de hacer el 
        // public PhotoBook() : this(16)
        // {

        // }

        public PhotoBook(int p)
        {
            pages = p;
            id = idGenerated++;
        }


        public int GetNumberPages()
        {
            return pages;
        }
    }
}