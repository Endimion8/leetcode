namespace KafkaMessageConverter
{
    public enum SecurityFormStatus
    {
        /// <summary>
        ///     Не заполнена
        /// </summary>
        Created = 0,

        /// <summary>
        ///     Заполнена
        /// </summary>
        Filled = 1,

        /// <summary>
        ///     Отправлена на проверку
        /// </summary>
        Completed = 2,

        /// <summary>
        ///     Возвращена на дозаполнение
        /// </summary>
        Return = 3,

        /// <summary>
        ///     Утверждена
        /// </summary>
        Accept = 4,

        /// <summary>
        ///     Отказ
        /// </summary>
        Reject = 5,

        /// <summary>
        ///     Отмена проверки
        /// </summary>
        Cancel = 6
    }
}