namespace LibraryManagementAPI.Application.DTOs
{
    public class AuthorDTO : BaseDTO
    {

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? BirthDate { get; set; }
        public string? Nationality { get; set; }
    }
}
