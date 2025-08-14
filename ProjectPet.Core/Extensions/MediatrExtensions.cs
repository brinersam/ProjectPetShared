using MediatR;
using ProjectPet.SharedKernel.Entities.AbstractBase;

namespace ProjectPet.Core.Extensions;
public static class MediatrExtensions
{
    public async static Task PublishDomainEventsAsync(this IPublisher publisher, DomainEventEntity entity, CancellationToken cancellationToken = default)
    {
        foreach (var domainEvent in entity.DomainEvents)
        {
            await publisher.Publish(domainEvent, cancellationToken);
        }
        entity.ClearDomainEvents();
    }

}