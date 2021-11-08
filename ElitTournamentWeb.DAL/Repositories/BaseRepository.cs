﻿using ElitTournamentWeb.DAL.Config;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElitTournamentWeb.DAL.Repositories.Interfaces;
using ElitTournamentWeb.Entities.Entities.Interfaces;

namespace ElitTournamentWeb.DAL.Repositories
{
	public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IBaseEntity
	{
		private ApplicationContext _context { get; set; }

		protected DbSet<TEntity> _dbSet { get; set; }

		public BaseRepository(ApplicationContext context)
		{
			_context = context;
			_dbSet = _context.Set<TEntity>();
		}

		public virtual async Task<TEntity> GetByIdAsync(int id)
		{
			return await _dbSet.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
		}

		public virtual async Task<IEnumerable<TEntity>> GetAll()
		{
			return await GetAllHelper().ToListAsync();
		}

		public virtual async Task CreateAsync(TEntity entity)
		{
			await _dbSet.AddAsync(entity);
			await _context.SaveChangesAsync();
		}

		public virtual async Task CreateAsync(IEnumerable<TEntity> collection)
		{
			await _dbSet.AddRangeAsync(collection);
			await _context.SaveChangesAsync();
		}

		public virtual async Task RemoveByIdAsync(int id)
		{
			var entity = await GetByIdAsync(id);
			_dbSet.Remove(entity);
			await _context.SaveChangesAsync();
		}

		public virtual async Task RemoveAsync(TEntity entity)
		{
			_dbSet.Remove(entity);
			await _context.SaveChangesAsync();
		}

		public virtual async Task RemoveAsync(IEnumerable<TEntity> entities)
		{
			_dbSet.RemoveRange(entities);
			await _context.SaveChangesAsync();
		}
		
		public virtual async Task Update(TEntity entity)
		{
			_dbSet.Update(entity);
			await _context.SaveChangesAsync();
		}
		
		public virtual async Task Update(IEnumerable<TEntity> entities)
		{
			_dbSet.UpdateRange(entities);
			await _context.SaveChangesAsync();
		}

		protected IQueryable<TEntity> GetAllHelper()
		{
			return _dbSet.AsNoTracking();
		}
	}
}
