namespace Backend.Entities
{
    public class Pet
    {
        public Guid Id { get; set; }

        public string Especies { get; set; }

        public string PetBreed { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }
    }
}
