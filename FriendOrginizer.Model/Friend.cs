using System.ComponentModel.DataAnnotations;

namespace FriendOrginizer.Model
{
    public class Friend
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string  Email { get; set; }
    }
}
