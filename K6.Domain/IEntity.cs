namespace K6.Domain;

public interface IEntity<TId>
{
    TId Id { get; }
}