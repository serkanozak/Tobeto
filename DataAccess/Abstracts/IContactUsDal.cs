﻿using Core.DataAccess.Repositories;
using Entities;

namespace DataAccess.Abstracts;

public interface IContactUsDal : IRepository<ContactUs, Guid>, IAsyncRepository<ContactUs, Guid>
{

}

