﻿using Microsoft.EntityFrameworkCore;
using YumBlazor.Data;
using YumBlazor.Repository.IRepository;

namespace YumBlazor.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Product> CreateAsync(Product obj)
        {
            await _db.Product.AddAsync(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var obj =await _db.Product.FirstOrDefaultAsync(x => x.Id == id);
            if (obj != null) 
            {
                _db.Product.Remove(obj);
               return (await _db.SaveChangesAsync())>0;
            }
            return false;
        }

        public async Task<Product> GetAsync(int id)
        {
            var obj =await _db.Product.FirstOrDefaultAsync(x => x.Id == id);
            if(obj == null)
            {
                return new Product();
            }
            return obj;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _db.Product.Include(c=>c.Category).ToListAsync();
        }

        public async Task<Product> UpdateAsync(Product obj)
        {
            var objFromDb =await _db.Product.FirstOrDefaultAsync(x => x.Id == obj.Id);
            if (objFromDb is not null) 
            {
                objFromDb.Name = obj.Name;
                objFromDb.Description = obj.Description;
                objFromDb.Price = obj.Price;
                objFromDb.CategoryId = obj.CategoryId;
                objFromDb.ImageUrl = obj.ImageUrl;

                
                _db.Product.Update(objFromDb);
                await _db.SaveChangesAsync();
                return objFromDb;
            }
            return obj;
            

        }
    }
}
