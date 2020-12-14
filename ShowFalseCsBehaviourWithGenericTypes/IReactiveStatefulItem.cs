namespace ShowFalseCsBehaviourWithGenericTypes
{
    public interface IReactiveStatefulItem
    {
        bool HasChanges { get;}
        bool IsDirty { get;}
        void ResetIsDirty(bool isDirty = false);
        void ApplyChanges();
        void Rollback();
    }

    public interface IReactiveStatefulItem<T> : IReactiveStatefulItem
    {
        
    }
    
    // this will provide type safety, because of c# leaks
    public interface IReactiveStatefulItem<T, TThis> : IReactiveStatefulItem<T>
    {
        
    }
}