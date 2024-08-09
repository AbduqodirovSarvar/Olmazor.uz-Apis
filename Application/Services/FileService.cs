using Application.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class FileService : IFileService
    {
        private readonly string _filesDirectory;

        public FileService(IHostEnvironment env)
        {
            if (env.IsProduction())
            {
                _filesDirectory = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                                    ? Path.Combine(Directory.GetCurrentDirectory(), "..", "Files")
                                    : Path.Combine("/app/Files");
            }
            else
            {
                _filesDirectory = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                                    ? Path.Combine(Directory.GetCurrentDirectory(), "..", "OlmaTech.Application", "Files")
                                    : Path.Combine("/app/Files");
            }

            Directory.CreateDirectory(_filesDirectory);
        }

        public Task RemoveFileAsync(string? fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                return Task.CompletedTask;
            }

            try
            {
                string filePath = Path.Combine(_filesDirectory, fileName);
                string fullPath = Path.GetFullPath(filePath);

                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                }

                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error removing file: {ex.Message}");
                throw;
            }
        }

        public async Task<string?> SaveFileAsync(IFormFile? file)
        {
            if (file == null)
            {
                return null;
            }

            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName)!;
            Console.WriteLine(fileName);
            string filePath = Path.Combine(_filesDirectory, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return fileName;
        }

        public Stream? GetFileByFileName(string fileName)
        {
            try
            {
                string filePath = Path.Combine(_filesDirectory, fileName);
                string fullPath = Path.GetFullPath(filePath);

                if (File.Exists(fullPath))
                {
                    return new FileStream(fullPath, FileMode.Open, FileAccess.Read);
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving file: {ex.Message}");
                throw;
            }
        }

        public string GetFilePath(string fileName)
        {
            try
            {
                string filePath = Path.Combine(_filesDirectory, fileName);
                string fullPath = Path.GetFullPath(filePath);
                return fullPath;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving file: {ex.Message}");
                throw;
            }
        }
    }
}
