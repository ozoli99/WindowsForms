namespace DocumentStatist.Persistence
{
    [Serializable]
    public class FileManagerException: IOException
    {
        public FileManagerException() { }
        public FileManagerException(string message) : base(message) { }
        public FileManagerException(string message, Exception innerException) : base(message, innerException) { }
        public FileManagerException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
