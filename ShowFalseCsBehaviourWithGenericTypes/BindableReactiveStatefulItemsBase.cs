using System;
using System.Linq.Expressions;

namespace ShowFalseCsBehaviourWithGenericTypes
{
    public class BindableReactiveStatefulItemsBase
    {
        internal virtual void ReallocateBindersNotifications(){}
    }
    
    public abstract class BindableReactiveStatefulItemsBase<T, TStates, TReactiveStatefulItem> : BindableReactiveStatefulItemsBase,
            IReactiveStatefulItem<T, TReactiveStatefulItem>
        where TReactiveStatefulItem : class, IReactiveStatefulItem
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

        public void BindState<TI>(
            Expression<Func<TStates, IReactiveStatefulItem<TI, TReactiveStatefulItem>>> stateExp
        )
        {
            
        }
    }
}