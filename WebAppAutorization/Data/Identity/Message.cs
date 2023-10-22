using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppAutorization.Data.Identity
{
    [Table("Messages", Schema = "data")]
    public class Message
    {
        
        public int Id { get; set; }
        public string Heading { get; set; }
        public string Text { get; set; }
    }
}
