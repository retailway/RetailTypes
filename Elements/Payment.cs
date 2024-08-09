namespace RetailWay.Types.Elements
{
    public struct Payment
    {
        public int CashSum;
        public int EcashSum;
        public int PrepaidSum;
        public int ProvisionSum;
        public int CreditSum;
        public Payment (int cash, int ecash, int prepaid, int provision, int credit)
        {
            CashSum = cash;
            EcashSum = ecash;
            PrepaidSum = prepaid;
            ProvisionSum = provision;
            CreditSum = credit;
        }
        public bool Equals(Payment other) =>
            EcashSum == other.EcashSum &&
            PrepaidSum == other.PrepaidSum &&
            CreditSum == other.CreditSum &&
            ProvisionSum == other.ProvisionSum &&
            CashSum == other.CashSum;
    }
}
