﻿using System.Data.Entity;
using Microsoft.Practices.Unity;
using TP.Interfaces.IRepository;
using TP.Repository.BaseRepository;
using TP.Repository.Repositories;

namespace TP.Repository
{
    public static class TypeRegistrations
    {
        public static void RegisterType(IUnityContainer unityContainer)
        {
            
            unityContainer.RegisterType<IAspNetUserRepository, AspNetUserRepository>();
            unityContainer.RegisterType<DbContext, BaseDbContext>(new PerRequestLifetimeManager());

        }
    }
}