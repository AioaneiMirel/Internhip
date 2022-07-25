namespace UserCreationRefactored
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages.Welcome();

            var user = InputCapture.Capture();

            var isDataValid = Validator.Validate(user);

            if (!isDataValid)
            {
                Messages.CloseApplication();
                return;
            }

            UserGenerator.Create(user);

            Messages.CloseApplication();
        }
    }
}
