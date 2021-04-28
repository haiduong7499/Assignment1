using Assignment.BackEnd.Services;
using Moq;

namespace Assignment.Test.Services
{
    public static class FileStorageService
    {
        public static IStorageService IStorageService()
        {
            var fileStorageService = Mock.Of<IStorageService>();

            return fileStorageService;
        }
    }
}
