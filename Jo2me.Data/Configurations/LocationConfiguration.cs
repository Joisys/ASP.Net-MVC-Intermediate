using System.Data.Entity.ModelConfiguration;
using Jo2me.Model;

namespace Jo2me.Data.Configurations
{
    internal class LocationConfiguration : EntityTypeConfiguration<Location>
    {
        public LocationConfiguration()
        {
            ToTable("Location");
            Property(location => location.Name).IsRequired().HasMaxLength(100);
        }
    }
}
