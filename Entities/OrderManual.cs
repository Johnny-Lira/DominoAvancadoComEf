namespace DominoAvancadoComEf.Entities
{
    public class OrderManual : Order
    {
        public void Cancel()
        {
            EndDate = Utils.Utils.BrasiliaTimeNow();
            Status = OrderStatus.Canceled;
        }

        public static class CreateOrder
        {
            public static OrderManual Create(DateTime startDate)
            {

                if (startDate > Utils.Utils.BrasiliaTimeNow())
                {
                    throw new Exception("A data de início não pode ser no futuro");
                }

                return new OrderManual()
                {
                    Id = Guid.NewGuid(),
                    StartDate = startDate,
                    Status = OrderStatus.Active,
                    OrderCreationMethod = CreationMethod.Manual
                };
            }
        }
    }
}
