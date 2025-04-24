using Microsoft.AspNetCore.Http;

namespace _0_FramWork
{
    public interface IFileUploader
    {
        string Upload(IFormFile file, string path);
    }
}
