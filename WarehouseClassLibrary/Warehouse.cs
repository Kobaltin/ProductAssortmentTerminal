using AssortimentFormationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WarehouseClassLibrary
{
    internal class Warehouse<T> : IWarehouse<T> where T : IProduct
    {
        /// <summary>
        /// Заменить строковое представение всех продуктов в контейнере, зная новый идентификатор склада
        /// </summary>
        private void changeInformationInAllProducts(int id)
        {
            for (int i = 0; i < Size; i++) 
            {
                if (_array[i] != null) 
                {
                    _array[i].setText(id,i);
                }
            }
        }
        /// <summary>
        /// Массив, хранящий объекты
        /// </summary>
        private T[] _array;

        private int _size;
        /// <summary>
        /// Своййство размера миассива
        /// </summary>
        public int Size { get => _size; private set => _size = value; }
        /// <summary>
        /// Защищенны конструктор
        /// </summary>

        protected Warehouse(int size, int id)
        {
            _array = new T[size];
            Id = id;
            Size = size;
        }
        /// <summary>
        /// Метод приведения кортежа к складу
        /// </summary>
        public static implicit operator Warehouse<T>((int number, int id) parametrs)
        {
            return new Warehouse<T>(parametrs.number, parametrs.id);
        }
        /// <summary>
        /// Метод приведения числа к складу
        /// </summary>
        public static implicit operator Warehouse<T>(int number)
        {
            return new Warehouse<T>(number, 0);
        } 
        private int _id;
        /// <summary>
        /// Публичное свойство идентификатора скада
        /// </summary>
        public virtual int Id 
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                changeInformationInAllProducts(_id);
            } 
        }
        /// <summary>
        /// Индексатор
        /// </summary>

        public virtual T this[int index]
        {
            get
            {
                if (index < Size && index >= 0)
                {
                    T productFromPosition = _array[index];
                    _array[index] = default;
                    return productFromPosition;
                }
                else return default;
            }
            set
            {
                if (index < Size && index >= 0)
                {
                    _array[index] = value;
                    _array[index].setText(this);
                }
                else return;
            }
        }
        /// <summary>
        /// Реализация метода, кладущего объект в первую попашую ячейку
        /// </summary>
        public void Push(T product)
        {
            for (int i = 0; i < Size; i++)
            {
                if (_array[i] == null)
                {
                    _array[i] = product;
                    _array[i].setText(Id,i);
                    break;
                }
            }
        }
        /// <summary>
        /// Реализация метода, кладущего объект по индексу
        /// </summary>
        public void Push(T product, int index)
        {
            if (index < Size && index >= 0)
            {
                _array[index] = product;
                _array[index].setText(Id, index);
            }
        }
        /// <summary>
        /// Реализация метода, забирающего объект по индексу
        /// </summary>
        public T Pop(int index)
        {
            return _array[index];
        }
        /// <summary>
        /// Реализация метода, перестановки-обмена(используется в быстрой сортировке)
        /// </summary>
        public void Swap(int firstIndex, int secondindex)
        {
            if (firstIndex < Size && firstIndex >= 0 && secondindex < Size && secondindex >= 0)
            {
                T tmp = _array[firstIndex];
                _array[firstIndex] = _array[secondindex];
                _array[firstIndex].setText(Id, firstIndex);
                _array[secondindex] = tmp;
                _array[secondindex].setText(Id, secondindex);
            }
        }
        /// <summary>
        /// Реализация метода замены
        /// </summary>
        public T Replace(T product, int index)
        {
            return _array[index];
        }
        /// <summary>
        /// Реализация метода поиска по идентификатору
        /// </summary>
        public virtual int Find(int productId)
        {
            for (int i = 0; i < Size; i++)
            {
                if (_array[i].Id == productId)
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Реализация метода поиска по имени
        /// </summary>
        public virtual int Find(string productName)
        {
            for (int i = 0; i < Size; i++)
            {
                if (_array[i].ProductName == productName)
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Реализация метода сортировки по идентификатору
        /// </summary>
        public virtual void OrderById()
        {
            OrderById(0, Size - 1);

        }
        private void OrderById(int left, int right)
        {
                int i = left, j = right;
                int pivot = _array[(left + right) / 2].Id;

            do
            {
                while (_array[i].Id < pivot) i++;
                while (_array[j].Id > pivot) j--;
                if (i <= j)
                {
                    Swap(i, j);
                    i++; j--;
                }
            } while (i <= j);
            if (i < right) OrderById(i, right);
            if (j > left)  OrderById(left, j);
        }
        /// <summary>
        /// Реализация метода сортировки по имени
        /// </summary>
        public virtual void OrderByName()
        {
            OrderByName(0, Size - 1);
        }
        private void OrderByName(int left, int right)
        {
                int i = left, j = right;
            string pivot = _array[(left + right) / 2].ProductName;

            do
            {
                while (string.Compare(_array[i].ProductName, pivot, StringComparison.Ordinal) < 0) i++;
                while (string.Compare(_array[j].ProductName, pivot, StringComparison.Ordinal) > 0) j--;
                if (i <= j)
                {
                    Swap(i, j);
                    i++; j--;
                }

            } while (i <= j);
                if (i < right) OrderByName(i, right);
                if (j > left)  OrderByName(left, j);
        }
        /// <summary>
        /// Строковое представление
        /// </summary>
        public override string ToString()
        {
            string forShow = $"Идентификатор склада:{Id}\n";
            for (int i = 0; i < Size; i++)
            {
                if (_array[i] != null)
                {
                    forShow = forShow + _array[i].ToString() + "\n";
                }
                else
                    forShow = forShow + "Пустая ячейка" + "\n";
            }
            return forShow;
        }
    }
}
