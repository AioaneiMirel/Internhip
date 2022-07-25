namespace UserCreationRefactored
{
    public class Validator
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                Messages.ShowValidationErrorFor("First name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                Messages.ShowValidationErrorFor("Last name");
                return false;
            }

            return true;
        }
    }
}
