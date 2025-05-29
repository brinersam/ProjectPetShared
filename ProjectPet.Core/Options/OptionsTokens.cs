namespace ProjectPet.Core.Options;
public class OptionsTokens
{
    public const string SECTION = nameof(OptionsTokens);
    public string Issuer { get; init; } = String.Empty;
    public string Audience { get; init; } = String.Empty;
    public string Key { get; init; } = String.Empty;
    public int AccessExpiresMin { get; init; }
    public int RefreshExpiresMin { get; init; }
}
