using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproachWith2Tables.Models
{
    [Table("tblArticle")]
    public class Article
    {
       
        public int? ArticleId { get; set; }
        //[Key]
        [Required(ErrorMessage ="Please enter Article Title")]
        public string ArticleTitle { get; set; }
        [Required(ErrorMessage = "Please enter Article Content")]
        public string ArticleContent { get; set; }
        public int TutorialId { get; set; }
        public Tutorial? Tutorials { get; set; }=null;
    }
}
