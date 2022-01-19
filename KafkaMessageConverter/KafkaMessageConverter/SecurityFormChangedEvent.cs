namespace KafkaMessageConverter
{
    public class SecurityFormChangedEvent
    {
        /// <summary>
        /// Идентификатор сообщения
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Id анкеты, по нему находим результат
        /// </summary>
        public Guid SecurityFormId { get; set; }

        /// <summary>
        /// Результат анкеты
        /// </summary>
        public SecurityFormStatus SecurityFormStatus { get; set; }

        /// <summary>
        /// Время получения результата
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// Комментарий от СБ
        /// </summary>
        public string? Comment { get; set; }
    }
}