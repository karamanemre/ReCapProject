using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        public void Add(Color color);
        public void Delete(Color color);
        public void Uptade(Color color);
        public List<Color> GetAll();
        public List<Color> GetById(int id);
    }
}
