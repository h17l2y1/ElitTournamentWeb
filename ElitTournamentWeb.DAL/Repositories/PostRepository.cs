using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElitTournamentWeb.DAL.Config;
using ElitTournamentWeb.DAL.Repositories.Interfaces;
using ElitTournamentWeb.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElitTournamentWeb.DAL.Repositories
{
	public class PostRepository : BaseRepository<Post>, IPostRepository
	{
		public PostRepository(ApplicationContext context) : base(context)
		{
		}

		public async override Task<IEnumerable<Post>> GetAll()
		{
			return await GetAllHelper().OrderBy(o=>o.CreationDate).ToListAsync();
		}
	}
}