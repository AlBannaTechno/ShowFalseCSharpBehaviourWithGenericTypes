namespace ShowFalseCsBehaviourWithGenericTypes
{
    public class ValidatableReactiveStatefulItem<T, TMessage> : ValidatableReactiveStatefulItem<T, TMessage, bool>
    {
        
    }
    public class ValidatableReactiveStatefulItem<T, TMessage, TValidationResult> : ReactiveStatefulItem<T>,
        IValidatableReactiveStatefulItem<T, TMessage>
    {
        public bool IsCurrentValid { get; }
        public (bool isValid, T value, TMessage message) Validation { get; set; }
        public TMessage ValidationMessage { get; }
    }
}