namespace ContactTogetherApi.Dtos;

/// <summary>A single entry of a list of values: the key and its Thai display name.</summary>
public class LookupItemResponse
{
    public string Id { get; set; } = string.Empty;

    public string NameTh { get; set; } = string.Empty;
}
