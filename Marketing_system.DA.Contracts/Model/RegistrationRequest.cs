using Marketing_system.DA.Contracts.Shared;

namespace Marketing_system.DA.Contracts.Model
{
    public enum RegistrationRequestStatus
    {
        Pending,
        Approved,
        Rejected
    }

    public class RegistrationRequest : Entity
    {
        public int? UserId { get; set; } // TODO: If request is rejected, we will delete user mapped to this request.
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public RegistrationRequestStatus Status { get; set; }
        public string? Reason { get; set; }
        public string? Token { get; set; }
        public DateTime? TokenExpirationDate { get; set; }
    }
}
