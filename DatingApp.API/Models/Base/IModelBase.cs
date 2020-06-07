namespace DatingApp.API.Models.Base
{
    public interface IModelBase
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }
    }
}
