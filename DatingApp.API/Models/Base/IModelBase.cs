namespace DatingApp.API.Models.Base
{
    public interface IModelBase
    {
        string Id { get; set; }
        string Name { get; set; }
        bool Deleted { get; set; }
    }
}
