using Microsoft.AspNetCore.Http.HttpResults;

namespace ERP_Backend.Entities.Order
{
    public enum OrderEnum
    {
        Created, Payed, Shipped, Canceled, Completed
    }
}
