using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewForUnits
{
    public class Class1
    {
        public static int Max(int[] array)//поиск максимума массива
        {
            if (array==null)
            {
                throw new ArgumentNullException("Empty Massive");
            }
            int max = array[0];
            for (int i=0;i<array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }
            return max;
        }

        public static int Min(int[] array)// поиск минимума массива
        {
            if (array == null)
            {
                throw new ArgumentNullException("Empty Massive");
            }
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
            }
            return min;
        }

        public static double AVGvalue(int[] array)//поиск среднего
        {
            double sum = 0;
            for (int i=0;i<array.Length;i++)
            {
                sum = sum + array[i];
            }
            return (sum / array.Length);
        }

        

    }

    public class CreateArray
    {
        public double[] array;

        public CreateArray(double[] mass)//присвоение значений массиву
        {
            array = mass;
        }

        public  double SUM()//поиск суммы
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum;
        }

        public void SortL_to_H()//сортировка массива по возрастанию
        {
            int i,j;
            double t;
            for (i = 0; i < array.Length; i++)
            {
                for (j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        t = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = t;
                    }
                }
            }
        }

        public void SortH_to_L()//сортировка массива по убыванию
        {
            int i, j;
            double t;
            for (i = 0; i < array.Length; i++)
            {
                for (j = 0; j < array.Length-1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        t = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = t;
                    }
                }
            }
        }

        public void POW()//возведение элементов массива в квадрат
        {
            for(int i = 0;i<array.Length;i++)
            {
                array[i] = array[i] * array[i];
            }
        }
    }
}
