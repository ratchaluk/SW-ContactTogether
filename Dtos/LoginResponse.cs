namespace ContactTogetherApi.Dtos;

public class LoginResponse
{
    public int StatusCode { get; set; }

    public string Token { get; set; } = string.Empty;

    public string TokenType { get; set; } = "Bearer";

    public DateTime ExpiresAtUtc { get; set; }

    public string EmployeeId { get; set; } = string.Empty;

    public string UserName { get; set; } = string.Empty;

    public string RoleId { get; set; } = string.Empty;
}
