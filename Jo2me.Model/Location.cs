using System.Collections.Generic;

namespace Jo2me.Model
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Stage> Properties { get; set; } // 'virtual' is for lazy loading and change tracking.
    }
}