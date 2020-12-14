namespace ShowFalseCsBehaviourWithGenericTypes
{
    public class User
    {
        public string Name { get; set; }
    }
    
    public class UserStates : ValidatableReactiveStatefulItems<User, UserStates>
    {
        public ValidatableReactiveStatefulItem<string, string> Name { get; set; }
        public UserStates()
        {
            this.BindState(s => s.Name);
        }
    }
}