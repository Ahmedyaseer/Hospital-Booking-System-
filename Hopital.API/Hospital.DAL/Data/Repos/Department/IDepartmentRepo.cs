﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL
{
    public interface IDepartmentRepo:IGenericRepos<Department>
    {
        Department SearchByName(string name);
    }
}
