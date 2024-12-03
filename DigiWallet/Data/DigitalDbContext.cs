using Microsoft.EntityFrameworkCore;

namespace DigiWallet.Data
{
    public class DigitalDbContext:DbContext
    {
        public DigitalDbContext(DbContextOptions<DigitalDbContext> options) :base(options)
        {
            
        }
    }
}
