﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Data.Infrastructure
{
	public interface IUnitOfWork : IDisposable
	{
		IRepository<T> GetRepository<T>() where T : class;
		void Commit();

	}

}
