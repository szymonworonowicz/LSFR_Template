namespace LSFR.Tests
{
    internal class SynchronousStreamCipher
    {
        private string startState;
        private string taps;

        public SynchronousStreamCipher(string startState, string taps)
        {
            this.startState = startState;
            this.taps = taps;
        }

        public object Encrypt(string input)
        {
            throw new System.NotImplementedException();
        }

        public object Decrypt(string input)
        {
            throw new System.NotImplementedException();
        }
    }
}