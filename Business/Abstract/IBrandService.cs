using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        public void Add(Brand brand);
        public void Delete(Brand brand);
        public void Uptade(Brand brand);
        public List<Brand> GetAll();
        public List<Brand> GetById(int id);
      
    }
}
