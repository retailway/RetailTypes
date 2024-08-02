namespace RetailWay.Types.Enums
{
    public enum SubjectType
    {
        /// <summary>
        /// Неизвестно
        /// </summary>
        Unknown,
        /// <summary>
        /// Товар
        /// </summary>
        Product,
        /// <summary>
        /// Акцизный товар
        /// </summary>
        ExcisableProduct,
        /// <summary>
        /// Работа
        /// </summary>
        Work,
        /// <summary>
        /// Услуга
        /// </summary>
        Service,
        /// <summary>
        /// Ставка азартной игры
        /// </summary>
        GamblingRate,
        /// <summary>
        /// Выигрыш азартной игры
        /// </summary>
        GamblingWin,
        /// <summary>
        /// Ставка лотереи
        /// </summary>
        LotteryTicket,
        /// <summary>
        /// Выигрыш лотереи
        /// </summary>
        LotteryWin,
        /// <summary>
        /// Результат интеллектуальной деятельности
        /// </summary>
        ResultIntellectual,
        /// <summary>
        /// Платёж/Выплата
        /// </summary>
        Payment,
        /// <summary>
        /// Агентское вознаграждение
        /// </summary>
        AgencyRemuneration,
        /// <summary>
        /// Составной предмет расчёта
        /// </summary>
        Composite,
        /// <summary>
        /// Иной предмета расчёта
        /// </summary>
        Other,
        /// <summary>
        /// Имущественное право
        /// </summary>
        PropertyRight,
        /// <summary>
        /// Внереализационный доход
        /// </summary>
        NonOperatingIncome,
        /// <summary>
        /// Страховый взнос
        /// </summary>
        InsurancePremium,
        /// <summary>
        /// торговый сбор
        /// </summary>
        TradeFee,
        /// <summary>
        /// Курортный сбор
        /// </summary>
        ResortFee,
        /// <summary>
        /// Залог
        /// </summary>
        Pledge,
        /// <summary>
        /// Расходы
        /// </summary>
        Expense,
        /// <summary>
        /// Взнос на ОПС ИП
        /// </summary>
        ContributionsForOPSIE,
        /// <summary>
        /// Взнос на ОПС
        /// </summary>
        ContributionToOPI,
        /// <summary>
        /// Взнос на ОМС ИП
        /// </summary>
        ContributionToCMIIE,
        /// <summary>
        /// Взнос на ОМС
        /// </summary>
        ContributionToCMI,
        /// <summary>
        /// Взнос на ОСС
        /// </summary>
        ContributionToCSI,
        /// <summary>
        /// Платёж казино
        /// </summary>
        CasunoPayment,
        /// <summary>
        /// Выдача денежных средств
        /// </summary>
        IssueMoney,
        /// <summary>
        /// Акцизный товар с маркировкой без проверки
        /// </summary>
        ExcisableProductNoMark = 30,
        /// <summary>
        /// Акцизный товар с маркировкой
        /// </summary>
        ExcisableProductMark,
        /// <summary>
        /// Маркированный товар без проверки
        /// </summary>
        ProductNoMark,
        /// <summary>
        /// Маркированный товар
        /// </summary>
        ProductMark
    }
}
