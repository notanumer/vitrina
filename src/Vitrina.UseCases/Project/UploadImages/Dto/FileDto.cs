﻿namespace Vitrina.UseCases.Project.UploadImages.Dto;

/// <summary>
/// File dto.
/// </summary>
public class FileDto
{
    /// <summary>
    /// Data.
    /// </summary>
    public Stream Data { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    public string FileName { get; init; }

    /// <summary>
    /// Content type.
    /// </summary>
    public string ContentType { get; init; }

    /// <summary>
    /// Constructor.
    /// </summary>
    public FileDto(Stream data, string fileName, string contentType)
    {
        Data = data;
        FileName = fileName;
        ContentType = contentType;
    }
}
