namespace N2.Documents;

/// <summary>
/// The document information for external use (DTO).
/// </summary>
public class DocumentInformation
{
    /// <summary>
    /// The unique identifier for the document.
    /// </summary>
    public Guid PublicId { get; init; }

    /// <summary>
    /// The name of the process for which the document is intended.
    /// This could be the process that created the document or the process
    /// that handles the document.
    /// </summary>
    public string ProcessName { get; init; } = string.Empty;

    /// <summary>
    /// The Dcmi type of the document explains the intent of the document.
    /// For instance, a document with a type of "Image" is intended as
    /// a visual representation, even if it is a word file.
    /// </summary>
    public AttachmentType DcmiType { get; init; }

    /// <summary>
    /// The location or path where the document content is stored.
    /// This can be a file path, a URL, a database reference or a reference to a physical location.
    /// </summary>
    public string DocumentIdentifier { get; init; } = string.Empty;

    /// <summary>
    /// Optional remarks about the document
    /// </summary>
    public string Remarks { get; init; } = string.Empty;

    /// <summary>
    /// The original name of the document, as it was added to the document store.
    /// </summary>
    public string FileName { get; init; } = string.Empty;

    /// <summary>
    /// The file extension of the document, without the separator.
    /// </summary>
    public string Extension { get; init; } = string.Empty;

    /// <summary>
    /// Indication that the document content is enabled and can be accessed.
    /// </summary>
    public bool IsEnabled { get; init; }

    /// <summary>
    /// The size of the document in bytes.
    /// </summary>
    public int Size { get; init; }

    /// <summary>
    /// The date and time the document was created, in UTC.
    /// </summary>
    public DateTime Created { get; init; } = DateTime.UnixEpoch;

    /// <summary>
    /// The unique identifier of the user or process that created the document.
    /// </summary>
    public Guid UploadedBy { get; init; }

    /// <summary>
    /// The roles that have access to the document.
    /// </summary>
    public IList<string> Roles { get; init; } = [];

    /// <summary>
    /// The tags that are associated with the document.
    /// </summary>
    public IList<string> Tags { get; init; } = [];
}