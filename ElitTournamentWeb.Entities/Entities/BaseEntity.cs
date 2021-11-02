using System;
using ElitTournamentWeb.Entities.Entities.Interfaces;
using Google.Cloud.Firestore;

namespace ElitTournamentWeb.Entities.Entities
{
	public class BaseEntity : IBaseEntity
	{
		[FirestoreProperty]
		public string Id { get; set; }
		[FirestoreProperty]
		public DateTime CreationDate { get; set; }
		
		public BaseEntity()
		{
			Id = Guid.NewGuid().ToString();
			CreationDate = DateTime.UtcNow;
		}
	}
}