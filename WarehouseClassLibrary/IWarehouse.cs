using AssortimentFormationLibrary;
namespace WarehouseClassLibrary
{
    public interface IWarehouse<T> where T : IProduct
        {/// <summary>
         /// Публичное свойство идентификатора
         /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Публичное свойство размера
        /// </summary>
        public int Size {  get; }
        /// <summary>
        /// Индексатор
        /// </summary>
        T this[int index] { get; set; }
        /// <summary>
        /// Функция добавления в первую свободную ячейку
        /// </summary>
        public void Push(T product);
        /// <summary>
        /// Функция добавления в выбранную ячейку
        /// </summary>
        public void Push(T product, int index);
        /// <summary>
        /// Функция забирающая объект по индексу
        /// </summary>
        public T Pop(int index);
        /// <summary>
        /// Перестановка
        /// </summary>
        public void Swap(int firstIndex, int secondindex);
        /// <summary>
        ///Замена
        /// </summary>
        public T Replace(T product, int index);
        /// <summary>
        /// Поиск по идентификатору
        /// </summary>
        public int Find(int productId);
        /// <summary>
        /// Поиск по имени
        /// </summary>
        public int Find(string productName);
        /// <summary>
        /// Сортировка по идентификатору
        /// </summary>
        public void OrderById();
        /// <summary>
        /// Сортировка по имени
        /// </summary>
        public void OrderByName();


    }
}
