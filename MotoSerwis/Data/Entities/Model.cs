namespace MotoSerwis.Data.Entities
{
    public class Model
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public Make Make { get; set; }
        public string Name { get; set; }
    }
}
