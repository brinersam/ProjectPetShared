namespace ProjectPet.Core.Database;
public interface IDatabaseSeeder
{
    Task SeedAsync(bool verboseLogging = false, CancellationToken cancellationToken = default);
}
