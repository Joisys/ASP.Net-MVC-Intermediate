namespace Jo2me.Model
{
    public class Stage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
    }
}