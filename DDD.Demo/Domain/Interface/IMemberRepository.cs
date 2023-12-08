﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Demo.Domain.Interface
{
    /// <summary>
    /// 会员借口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IMemberRepository<T> where T : class MyClass
    {
        List<T> Select();
        T Find(int Id);
        T Save(T t);
    }

}
