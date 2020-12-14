namespace ShowFalseCsBehaviourWithGenericTypes
{
    public class ReactiveStatefulItem<T> : ReactiveStatefulItem<T, IReactiveStatefulItem>
    {
        
    }

    public class ReactiveStatefulItem<T, TThis> : IReactiveStatefulItem<T, TThis>
    {
        public bool HasChanges { get; }
        public bool IsDirty { get; }
        public void ResetIsDirty(bool isDirty = false)
        {
            throw new System.NotImplementedException();
        }

        public void ApplyChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Rollback()
        {
            throw new System.NotImplementedException();
        }
    }
}