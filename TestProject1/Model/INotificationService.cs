namespace CommerceProject.Model
{
    internal interface INotificationService
    {
        void NotifyCustomerOrderCreated(Cart cart);
    }
}