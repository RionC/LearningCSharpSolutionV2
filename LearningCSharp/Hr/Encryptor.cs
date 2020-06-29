namespace LearningCSharp.Hr
{
    // can not derive from sealed classes
    public sealed class Encryptor
    {
        public bool IsGoodPassword(string password)
        {
            return password == "super_secret";
        }
    }
}
