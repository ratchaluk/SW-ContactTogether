namespace ContactTogetherApi.Dtos;

/// <summary>Plain status/message payload used for logout and for failed logins.</summary>
public class MessageResponse
{
    public MessageResponse()
    {
    }

    public MessageResponse(int statusCode, string message)
    {
        StatusCode = statusCode;
        Message = message;
    }

    public int StatusCode { get; set; }

    public string Message { get; set; } = string.Empty;
}
