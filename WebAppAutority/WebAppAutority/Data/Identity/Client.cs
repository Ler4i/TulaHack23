using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppAutority.Data.Identity
{
    [Table("Clients", Schema = "data")]
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Post  { get; set; }
        public bool Delete { get; set; }
        public string Email { get; set; }

    }
}
