namespace ProjectPet.Core.Files;

[Obsolete("Use whatever file microservice provides after thats done")]
public record FileDto(
    Stream Stream,
    string FilePath,
    string ContentType);