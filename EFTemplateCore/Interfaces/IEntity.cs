

namespace EFTemplateCore.Interfaces
{
    /// <summary>
    /// EF interface entity. 
    /// Common operations may be included for poco objects in the future.
    /// Ex: GetUniqueKey didn't worked for this interface.Auto built reposotory's have this feature.
    /// But GetById can be implemented according to a constant key as "Id" column
    /// </summary>
    public interface IEntity {
        //todo:GetUniquekey not applicable for multiple columns keys and indexes!!!
        //object GetUniqueKey();
        //Expression<Func<IEntity, bool>> GetUniqueKeyPredicate(object customerKey);
    }
}
