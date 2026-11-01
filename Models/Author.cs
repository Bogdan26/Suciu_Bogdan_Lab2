using System.ComponentModel.DataAnnotations;

namespace Suciu_Bogdan_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Display(Name = "AuthorName")]
        public string FullName {
            get { return LastName + " " + FirstName; }
        }


        [ScaffoldColumn(false)]

        public ICollection<Book>? Books { get; set; }



    }
}
