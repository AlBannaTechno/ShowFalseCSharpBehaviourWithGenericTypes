namespace ShowFalseCsBehaviourWithGenericTypes
{
    public interface IValidatableReactiveStatefulItem : IReactiveStatefulItem
    {
        bool IsCurrentValid { get; }
    }

    public interface IValidatableReactiveStatefulItem<T> : IValidatableReactiveStatefulItem,  IReactiveStatefulItem<T, IValidatableReactiveStatefulItem>
    {
        
    }

    public interface IValidatableReactiveStatefulItem<T, TMessage> : IValidatableReactiveStatefulItem<T>
    {
        (bool isValid, T value, TMessage message) Validation { get; set; }
        TMessage ValidationMessage { get; }
        
    }
    
    public abstract class ValidatableReactiveStatefulItems<T, TStates> :
        BindableReactiveStatefulItemsBase<T, TStates, IValidatableReactiveStatefulItem>,
        IValidatableReactiveStatefulItem
    {
        public bool IsCurrentValid { get; }
    }
}