using System.ComponentModel.DataAnnotations;

namespace RES_APIs.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
}
