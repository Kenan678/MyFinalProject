﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();    
        Category GetById(int categoryid);
        
    }
}