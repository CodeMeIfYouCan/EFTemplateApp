namespace EFTemplateCore.Utils
{
    public class SingletonProvider<T> where T : class, new()
    {
        public static T Instance { get { return Nested.instance; } }
        private class Nested
        {
            static Nested()
            {
            }

            internal static readonly T instance = new T();
        }
    }
}
