namespace Placica.Core.Contracts.ServiceLibrary.Dto
{
    public class Usuario
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PictureUrl { get; set; }
        public string Provider { get; set; }
    }
}