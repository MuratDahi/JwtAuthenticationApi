namespace JwtAuthenticationApi.DTOs;

public class CreateTicketRequestDto
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Priority { get; set; } = "Medium";

    public int CreatedByUserId { get; set; }
}