﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Domain.Entities;
using WebSite.Domain.Repositories.Abstract;

namespace WebSite.Domain.Repositories.EntityFramework
{
    public class EFServiceItemsRepository : IServiceItemsRepository
    {
        private readonly AppDbContext context;
        public EFServiceItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ServiceItem> GetServiceItems()
        {
            return context.ServiceItems;
        }

        public ServiceItem GetServiceItemById(Guid id)
        {
            return context.ServiceItems.FirstOrDefault(x => x.Id == id);
        }

        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteServiceItem(Guid id)
        {
            context.ServiceItems.Remove(new ServiceItem() { Id = id });
            context.SaveChanges();
        }
    }
}
