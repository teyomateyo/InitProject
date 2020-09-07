namespace initProject.Domain.Models
{
    public interface IDBEntity<T>
    {
        T Id { get; set; }
    }
}