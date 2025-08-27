namespace reciplease_backend.Data.Models
{
    public class User
    {
        // We won't be putting provider identity/access tokens here long term. If we must, encrypt and rotate
        // Need to store our own user id without relying on auth provider's id (UUID)
        // As far as passwords go, we'll probably just have to log users out and have them create a new password
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Email { get; set; }
        public bool EmailVerified { get; set; }
        public string? Name { get; set; }
        public string Status { get; set; } = "active";
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;
        //public ICollection<UserIdentity> Identities { get; set; } = new List<UserIdentity>();
        //public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

        // The app will start out not really having any boundaries with Authorization, so no need to create another model for that yet


        public ICollection<Recipe> Recipes { get; } = new List<Recipe>();

    }
}
