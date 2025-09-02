namespace ProjectPet.Core.Options;

public class OptionsTokens
{
    public const string SECTION = nameof(OptionsTokens);

    public bool GenerateTokens { get; init; } = false;

    public string SecretKey { get; init; } = "DEFAULT-SECRET-KEY";

    public int AccessExpiresMin { get; init; }

    public int RefreshExpiresMin { get; init; }
}