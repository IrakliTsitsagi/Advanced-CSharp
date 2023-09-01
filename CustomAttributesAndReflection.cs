using System.Reflection;
namespace CustomAttributes
{
    internal class CustomAttributesAndReflection
    {
        static void Main(string[] args)
        {
            MemberInfo info = typeof(Animals);
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                Console.WriteLine(attributes[i]);
            }
        }
    }
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class Developer : System.Attribute
    {
        private string developerName;
        private bool isReviewed;
        private string message;

        public Developer(string developerName, bool isReviewed, string message)
        {
            this.developerName = developerName;
            this.isReviewed = isReviewed;
            this.message = message;
        }

        public string DeveloperName
        { get => developerName; set => developerName = value; }

        public bool IsReviewed
        { get => IsReviewed; set => IsReviewed = value; }

        public string Message
        { get => message; set => message = value; }

    }

    [Developer("Ahmad Mohey", false, "This need to be finished tomorrow")]
    [Obsolete]
    class Animals
    {

    }
}