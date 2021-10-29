using System.Collections.Generic;
using ElitTournamentWeb.DAL.Repositories.Interface;
using ElitTournamentWeb.Entities.Entities.Interfaces;
using Google.Cloud.Firestore;
using Newtonsoft.Json;

namespace ElitTournamentWeb.DAL.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IBaseEntity
    {
        private readonly string _collectionName;
        private readonly FirestoreDb _firestore;

        protected BaseRepository(FirestoreDb firestore)
        {
            _collectionName = $"{nameof(TEntity)}s";
            _firestore = firestore;
        }

        public virtual TEntity Add(TEntity record)
        {
            CollectionReference colRef = _firestore.Collection(_collectionName);
            DocumentReference doc = colRef.AddAsync(record).GetAwaiter().GetResult();
            record.Id = doc.Id;
            return record;
        }

        public virtual bool Update(TEntity record)
        {
            DocumentReference recordRef = _firestore.Collection(_collectionName).Document(record.Id);
            recordRef.SetAsync(record, SetOptions.MergeAll).GetAwaiter().GetResult();
            return true;
        }

        public virtual bool Delete(TEntity record)
        {
            DocumentReference recordRef = _firestore.Collection(_collectionName).Document(record.Id);
            recordRef.DeleteAsync().GetAwaiter().GetResult();
            return true;
        }

        public virtual TEntity Get(TEntity record)
        {
            DocumentReference docRef = _firestore.Collection(_collectionName).Document(record.Id);
            DocumentSnapshot snapshot = docRef.GetSnapshotAsync().GetAwaiter().GetResult();
            if (snapshot.Exists)
            {
                TEntity usr = snapshot.ConvertTo<TEntity>();
                usr.Id = snapshot.Id;
                return usr;
            }
            else
            {
                return null;
            }
        }

        public virtual List<TEntity> GetAll()
        {
            Query query = _firestore.Collection(_collectionName);
            QuerySnapshot querySnapshot = query.GetSnapshotAsync().GetAwaiter().GetResult();
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

        public virtual List<TEntity> QueryRecords(Query query)
        {
            QuerySnapshot querySnapshot = query.GetSnapshotAsync().GetAwaiter().GetResult();
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