﻿using Microsoft.AspNetCore.Http;
using ProjectPet.Core.Files;

namespace ProjectPet.Framework;

public class FormFileProcessor : IAsyncDisposable
{
    private List<FileDto> _files = [];

    public List<FileDto> Process(IEnumerable<IFormFile> files)
    {
        foreach (var file in files)
        {
            _files.Add(new FileDto
            (
                file.OpenReadStream(),
                file.FileName,
                file.ContentType)
            );
        }
        return _files;
    }

    public async ValueTask DisposeAsync()
    {
        foreach (var file in _files)
            await file.Stream.DisposeAsync();
    }
}
