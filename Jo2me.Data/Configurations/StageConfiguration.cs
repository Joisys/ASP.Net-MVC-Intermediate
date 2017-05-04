using System.Data.Entity.ModelConfiguration;
using Jo2me.Model;

namespace Jo2me.Data.Configurations
{
    internal class StageConfiguration : EntityTypeConfiguration<Stage>
    {
        public StageConfiguration()
        {
            HasRequired(r => r.Location).WithMany().HasForeignKey(r => r.LocationId).WillCascadeOnDelete(true);
        }

    }
}
