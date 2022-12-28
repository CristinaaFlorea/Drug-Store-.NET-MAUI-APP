using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Proiect.Models;


namespace Proiect.Data
{
    public class ShoppingListDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public ShoppingListDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<ShoppingList>().Wait();
            _database.CreateTableAsync<Shop>().Wait();
        }
        public Task<List<ShoppingList>> GetShopListsAsync()
        {
            return _database.Table<ShoppingList>().ToListAsync();
        }
        public Task<ShoppingList> GetShopListAsync(int id)
        {
            return _database.Table<ShoppingList>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveShopListAsync(ShoppingList slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteShopListAsync(ShoppingList slist)
        {
            return _database.DeleteAsync(slist);
        }
        public Task<List<Shop>> GetShopsAsync()
        {
            return _database.Table<Shop>().ToListAsync();
        }
        public Task<int> SaveShopAsync(Shop shop)
        {
            if (shop.ID != 0)
            {
                return _database.UpdateAsync(shop);
            }
            else
            {
                return _database.InsertAsync(shop);
            }
        }
    }
}
