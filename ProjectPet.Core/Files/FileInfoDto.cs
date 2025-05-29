namespace ProjectPet.Core.Files;

[Obsolete("Use whatever file microservice provides after thats done")]
public record FileInfoDto(
    string ObjectName,
    string ObjectLink,
    string BucketName);
