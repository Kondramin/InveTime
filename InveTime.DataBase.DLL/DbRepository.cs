﻿using InveTime.DataBase.DLL.Context;
using InveTime.DataBase.DLL.Entityes.Base;
using InveTime.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InveTime.DataBase.DLL
{
    internal class DbRepository<T> : IRepository<T> where T : Entity, new()
    {
        private readonly InveTimeDB _db;
        private readonly DbSet<T> _Set;


        public bool AutoSaveChanges { get; set; } = true;


        public DbRepository(InveTimeDB db)
        {
            _db = db;
            _Set = db.Set<T>();
        }



        public IQueryable<T> Items => _Set;

        public T Add(T item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));
            _db.Entry(item).State = EntityState.Added;
            if (AutoSaveChanges) _db.SaveChanges();
            return item;
        }

        public async Task<T> AddAsync(T item, CancellationToken Cancel = default)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));
            _db.Entry(item).State = EntityState.Added;
            if (AutoSaveChanges) await _db.SaveChangesAsync(Cancel).ConfigureAwait(false);
            return item;
        }

        public T Get(int id) => Items.SingleOrDefault(item => item.Id == id);

        public async Task<T> GetAsync(int id, CancellationToken Cancel = default) => await Items
            .SingleOrDefaultAsync(item => item.Id == id, Cancel)
            .ConfigureAwait(false);


        public void Remove(int id)
        {
            _db.Remove(new T { Id = id });

            if (AutoSaveChanges) _db.SaveChanges();
        }

        public async Task RemoveAsync(int id, CancellationToken Cancel = default)
        {
            _db.Remove(new T { Id = id });

            if (AutoSaveChanges) await _db.SaveChangesAsync(Cancel).ConfigureAwait(false);
        }

        public void Update(T item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));
            _db.Entry(item).State = EntityState.Modified;
            if (AutoSaveChanges) _db.SaveChanges();
        }

        public async Task UpdateAsync(T item, CancellationToken Cancel = default)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));
            _db.Entry(item).State = EntityState.Modified;
            if (AutoSaveChanges) await _db.SaveChangesAsync(Cancel).ConfigureAwait(false);
        }
    }
}
