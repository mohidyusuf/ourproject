namespace Dal
{
    public class DbRegistration
    {
        internal readonly string? Registration;

        public static string? ConnectionString { get; set; } = "mongodb://localhost:27017";
        public static string? DatabaseName { get; set; } = "CarRentalApp";

        public static string? RegistrationCollection { get; set; } = "Registration";
        public static string? AboutCollection { get; set; } = "AboutShowroom";
        public static string? BranchCollection { get; set; } = "Branches";
        public static string? AddressCollection { get; set; } = "ShowroomAddresses";
        public static string? ProfileCollection { get; set; } = "ShowroomProfiles";
        public static string? SocialCollection { get; set; } = "SocialReferences";
        public static string? ContactCollection { get; set; } = "ContactShowrooms";
    }
}
