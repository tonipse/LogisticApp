namespace LogisticApp.Data
{
    public class Product
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }

        public string Name { get; set; }

    }
}
