using System.Collections.Generic;

namespace CommerceProject.Model
{

    public interface IReservationService
    {
        void ReserveInventory(IEnumerable<OrderItem> items);
    }
}
