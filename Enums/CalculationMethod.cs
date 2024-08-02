namespace RetailWay.Types.Enums
{
    public enum CalculationMethod
    {
        /// <summary>
        /// Неизвестно
        /// </summary>
        Unknown,
        /// <summary>
        /// Полная предоплата
        /// </summary>
        FullPrepaid,
        /// <summary>
        /// Частичная предоплата
        /// </summary>
        PartPrepaid,
        /// <summary>
        /// Аванс
        /// </summary>
        Advance,
        /// <summary>
        /// Полная оплата
        /// </summary>
        FullPayment,
        /// <summary>
        /// Частичная оплата
        /// </summary>
        PartPayment,
        /// <summary>
        /// Передача в кредит
        /// </summary>
        TransCredit,
        /// <summary>
        /// Оплата в кредит
        /// </summary>
        PayCredit
    }
}
