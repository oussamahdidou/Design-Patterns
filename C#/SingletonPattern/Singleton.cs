namespace Singleton
{
    public class Singleton
    {
        /// <summary>
        ///
        /// </summary>
        private static Singleton instance;
        private Singleton() { }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}