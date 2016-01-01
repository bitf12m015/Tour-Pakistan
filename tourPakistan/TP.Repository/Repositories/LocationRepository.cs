﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.Practices.Unity;
using TP.Interfaces.IRepository;
using TP.Models.DomainModels;
using TP.Repository.BaseRepository;

namespace TP.Repository.Repositories
{
    public sealed class LocationRepository : BaseRepository<Location>, ILocationRepository
    {
        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public LocationRepository(IUnityContainer container)
            : base(container)
        {
        }

        /// <summary>
        /// Primary database set
        /// </summary>
        protected override IDbSet<Location> DbSet
        {
            get { return db.Locations; }
        }
        #endregion

        public IEnumerable<Location> GetAllLocations()
        {
            return DbSet.Include(x=>x.Area).Include(x=>x.Province).Include(x=>x.Category).Select(x=>x).ToList();

        }

    }
}
