﻿using CSharpFunctionalExtensions;
using ProjectPet.SharedKernel.ErrorClasses;

namespace ProjectPet.SharedKernel.ValueObjects;

public record FilePath
{
    public string Path { get; }
    public string Extension { get; }
    private FilePath(
        string path,
        string extension)
    {
        Path = path;
        Extension = extension;
    }

    public static Result<Error, FilePath> Create(
        string path,
        string extension)
    {
        if (string.IsNullOrWhiteSpace(path))
            return Errors.General.ValueIsEmptyOrNull(path, nameof(path));

        if (string.IsNullOrWhiteSpace(extension))
            return Errors.General.ValueIsEmptyOrNull(extension, nameof(extension));

        return new FilePath(path, extension);
    }
}
