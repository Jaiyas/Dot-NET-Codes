using System.ComponentModel.DataAnnotations;

namespace OurHeroApiWithCodeFirstApproach.Model
{
    public class OurHero
    {
        [Key]
       public  int Id;
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public bool IsActive{ get; set; }

    }
}
