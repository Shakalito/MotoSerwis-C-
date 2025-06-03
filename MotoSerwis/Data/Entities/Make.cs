namespace MotoSerwis.Data.Entities
{
    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Model> Models { get; set; } = [];
    }
}
