namespace Backend.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public DateTime DateOfBirth { get; set; }

        public float Height { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
