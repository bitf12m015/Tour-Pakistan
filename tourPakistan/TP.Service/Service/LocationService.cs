﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DomainModels;
using Repository.Repositories;

namespace TP.Service.Service
{
    public class LocationService
    {
        private LocationRepository repository;
        public LocationService()
        {
            repository = new LocationRepository();
        }

        public List<Location> GetAll()
        {
            return repository.GetAll().ToList();
        }

        public Location GetById(long id)
        {
            return repository.GetById(id);
        }
    }
}