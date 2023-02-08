﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface ICompany<T>
    {
        T AddTrainerCompany(T com);

        List<T> GetAllCompany();

        T UpdateCompany(T com);

    }
}
