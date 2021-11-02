using ElitTournamentWeb.DAL.Repositories.Interface;
using ElitTournamentWeb.Entities.Entities;
using Google.Cloud.Firestore;

namespace ElitTournamentWeb.DAL.Repositories
{
    public class PostRepository: BaseRepository<Post>, IPostRepository
    {
        public PostRepository(FirestoreDb firestore): base(firestore)
        {
            CollectionName = $"{nameof(Post)}s";
        }
    }
}