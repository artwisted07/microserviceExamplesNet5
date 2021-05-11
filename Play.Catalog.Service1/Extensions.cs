using Play.Catalog.Service1.Dtos;
using Play.Catalog.Service1.Entities;

namespace Play.Catalog.Service1
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto(item.Id, item.Name, item.Description, item.Price, item.CreatedDate);
        }
    }
}