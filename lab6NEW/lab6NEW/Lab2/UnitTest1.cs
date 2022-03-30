using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NewForUnits.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Max_Positive()//тест для нахождения максимума при положительных значениях
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int expected = 9;
            int actual = Class1.Max(array);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Max_Negative()//тест для нахождения максимума при отрицательных значениях
        {
            int[] array = { -1, -13, -43, -60, -17, -19, -21 };
            int expected = -1;
            int actual = Class1.Max(array);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullArray()//вывод ошибки если массив пуст
        {
            int[] array = null;
            int actual1 = Class1.Max(array);
            int actual2 = Class1.Min(array);
        }


        [TestMethod]
        public void Min_Positive()//тест для нахождения минимума при положительных значениях
        {
            int[] array = { 1, 2, 11, 4, 25, 6, 12, 8, 9 };
            int expected = 1;
            int actual = Class1.Min(array);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Min_Negative()//тест для нахождения минимума при отрицательных значениях
        {
            int[] array = { -1, -13, -3, -60, -17, -19, -41 };
            int expected = -60;
            int actual = Class1.Min(array);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AVG_Test()//тест на поиск среднего
        {
            int[] array = {4,5,6,3};
            double expected= 4.5;
            double actual = Class1.AVGvalue(array);
            Assert.AreEqual(expected,actual,0.1);
        }
    }
    [TestClass]
    public class CreatedArray_Test
    {
        CreateArray ar;
        [TestInitialize]
        public void Initialize()//инициализация массива
        {
            double[] mass = {4,6,2,3};
            ar = new CreateArray(mass);
        }

        [TestMethod]
        public void Array_Sum_Test()//тест на нахождение суммы элементов массива
        {
            double expected = 15;
            double actual = ar.SUM();
            Assert.AreEqual(expected,actual,0.1);
        }

        [TestMethod]
        public void SortL_to_H_Test()//тест на псортировку массива по возрастанию
        {
            double[] expected = { 2,3,4,6 };
            ar.SortL_to_H();
            double[] actual = ar.array;
            for (int i = 0; i < expected.Length; i++) Assert.AreEqual(expected[i], actual[i]);
        }

        [TestMethod]
        public void SortH_to_L_Test()//тест на псортировку массива по убыванию
        {
            double[] expected = { 6,4,3,2 };
            ar.SortH_to_L();
            double[] actual = ar.array;
            for (int i = 0; i < expected.Length; i++) Assert.AreEqual(expected[i], actual[i]);
        }

        [TestMethod]
        public void POW_Test()//тест на возведение элементов массива в квадрат
        {
            double[] expected = { 16,36,4,9};
            ar.POW();
            double[] actual = ar.array;
            for (int i = 0; i < expected.Length; i++) Assert.AreEqual(expected[i], actual[i]);
        }
    }
}
