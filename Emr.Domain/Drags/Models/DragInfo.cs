namespace Emr.Domain.Drags.Models
{
    //Надо добавить в MapperProfile
    public class DragInfo
    {
        //Поля должны совпадать с полями из бд
        public string NameDrug { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Обязатель пустой конструктор
        /// </summary>
        public DragInfo()
        {
            
        }
    }
}
