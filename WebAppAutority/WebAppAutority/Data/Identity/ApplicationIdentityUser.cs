using Microsoft.AspNetCore.Identity;

namespace WebAppAutority.Data.Identity
{
    public class ApplicationIdentityUser : IdentityUser  
    {
        public long ApllicationId { get; set; } //связка между логином и ID зера в нашей программе
    }
}
