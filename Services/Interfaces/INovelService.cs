using NovelReadingApplication.Models;

namespace NovelReadingApplication.Services.Interfaces
{
    public interface INovelService
    {
        List<Novel> GetAllNovels();
        void AddNovel(Novel novel);
    }
}
