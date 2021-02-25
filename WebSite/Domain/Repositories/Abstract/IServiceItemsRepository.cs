using System;
using System.Linq;
using WebSite.Domain.Entities;

namespace WebSite.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}
