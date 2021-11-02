using System.Collections.Generic;
using System.Threading.Tasks;
using ElitTournamentWeb.DAL.Repositories.Interface;
using ElitTournamentWeb.Entities.Entities.Interfaces;
using Google.Cloud.Firestore;
using Newtonsoft.Json;

namespace ElitTournamentWeb.DAL.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IBaseEntity
    {
        protected string CollectionName;
        private readonly FirestoreDb _firestore;
        
        protected BaseRepository(FirestoreDb firestore)
        {
            _firestore = firestore;
        }

        public virtual async Task<TEntity> Add(TEntity record)
        {
            DocumentReference addedDocRef = await _firestore.Collection(CollectionName).AddAsync(record);
            record.Id = addedDocRef.Id;
            return record;
        }
        
        public virtual async Task Add(List<TEntity> records)
        {
            WriteBatch batch = _firestore.StartBatch();
            foreach (var entity in records)
            {
                DocumentReference docRef = _firestore.Collection(CollectionName).Document();
                batch.Set(docRef, entity);
            }

            await batch.CommitAsync();
        }

        public virtual async Task<TEntity> Update(TEntity record)
        {
            DocumentReference recordRef = _firestore.Collection(CollectionName).Document(record.Id);
            await recordRef.SetAsync(record, SetOptions.MergeAll);
            return record;
        }

        public virtual async Task<string> Delete(TEntity record)
        {
            DocumentReference recordRef = _firestore.Collection(CollectionName).Document(record.Id);
            await recordRef.DeleteAsync();
            return record.Id;
        }

        public virtual async Task<TEntity> Get(TEntity record)
        {
            DocumentReference docRef = _firestore.Collection(CollectionName).Document(record.Id);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                TEntity entity = snapshot.ConvertTo<TEntity>();
                entity.Id = snapshot.Id;
                return entity;
            }
            
            return null;
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            Query query = _firestore.Collection(CollectionName);
            QuerySnapshot querySnapshot = await query.GetSnapshotAsync();
            List<TEntity> list = new List<TEntity>();
            foreach (DocumentSnapshot snapshot in querySnapshot.Documents)
            {
                if (snapshot.Exists)
                {
                    TEntity entity = snapshot.ConvertTo<TEntity>();
                    list.Add(entity);
                }
            }

            return list;
        }

        public virtual async Task<List<TEntity>> QueryRecords(Query query)
        {
            QuerySnapshot querySnapshot = await query.GetSnapshotAsync();
            List<TEntity> list = new List<TEntity>();
            foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
            {
                if (documentSnapshot.Exists)
                {
                    Dictionary<string, object> city = documentSnapshot.ToDictionary();
                    string json = JsonConvert.SerializeObject(city);
                    TEntity newItem = JsonConvert.DeserializeObject<TEntity>(json);
                    newItem.Id = documentSnapshot.Id;
                    list.Add(newItem);
                }
            }

            return list;
        }
        
    }
}