namespace TryCatchLearning
{
    public class User
    {
        private string name = string.Empty;
        public string Name
        {
            get => name;
            set => name = value ??
                throw new ArgumentNullException(paramName: nameof(value), message: "Name cannot be null");
        }

    }
}
