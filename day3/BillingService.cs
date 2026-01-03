namespace Project2.Services
{
    class BillingService
    {
        public decimal ConsultationFee { get; set; }
        public decimal TestCharges { get; set; }
        public decimal RoomCharges { get; set; }

        public decimal CalculateTotal()
        {
            return ConsultationFee + TestCharges + RoomCharges;
        }
    }
}
