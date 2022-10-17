using System.ComponentModel.DataAnnotations;

namespace RES_APIs.Models
{
    public class Guest
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Deleted { get; set; }

    }
}
