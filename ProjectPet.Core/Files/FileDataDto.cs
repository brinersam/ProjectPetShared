namespace ProjectPet.Core.Files;

[Obsolete("Use whatever file microservice provides after thats done")]
public record FileDataDto(
    Stream Stream,
    string ObjectName,
    Guid UserId,
    string Bucket);
