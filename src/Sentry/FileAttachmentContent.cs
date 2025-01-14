using System.IO;

namespace Sentry
{
    /// <summary>
    /// Attachment sourced from the file system.
    /// </summary>
    public class FileAttachmentContent : IAttachmentContent
    {
        private readonly string _filePath;

        /// <summary>
        /// Creates a new instance of <see cref="FileAttachmentContent"/>.
        /// </summary>
        public FileAttachmentContent(string filePath) => _filePath = filePath;

        /// <inheritdoc />
        public Stream GetStream() => new FileStream(
            _filePath,
            FileMode.Open,
            FileAccess.Read,
            FileShare.ReadWrite,
            bufferSize: 4096,
            useAsync: true);
    }
}
