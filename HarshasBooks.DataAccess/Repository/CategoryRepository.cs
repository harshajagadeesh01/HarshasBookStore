﻿using HarshasBooks.DataAccess.Repository.IRepository;
using HarshasBooks.Models;
using HarshasBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarshasBooks.DataAccess.Repository
{
   public class CategoryRepository : Repository<Category>, ICategoryRepository 
    {
        private readonly ApplicationDbContext _db;

            public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            //use .NET LINQ to retrieve the first or default category object,
            // then pass the id as a generic entity which matches the category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null) // save changes if not null
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }

            throw new NotImplementedException(); //I may have to remove this line not sure atp
        }
    }
}
