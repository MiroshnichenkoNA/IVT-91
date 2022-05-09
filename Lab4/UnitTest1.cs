using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GameLibrary;
namespace GameUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_FieldExistence()
        {
            Class1 Field = new Class1();
            Assert.IsNotNull(Field);
        }

        [TestMethod]
        public void TestMethod_FieldCreation()
        {
            Class1 Field = new Class1();
            Field.Create_Field();
            char[,] expected = new char[,] { { '*', '*', '*' }, { '*', '*', '*' }, { '*', '*', '*' } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(expected[j, i], Field.field[j, i]);
                }
            }
        }
        [TestMethod]
        public void TestMethod_ElementInsert()
        {
            Class1 Field = new Class1();
            Field.Create_Field();
            Field.Insert_Element('X', 1, 1);
            char g = Field.field[0, 0];
            char expected = 'X';
            Assert.AreEqual(expected, g);
        }

        [TestMethod]
        public void TestMethod_NotEmptyElementInsert()
        {
            Class1 Field = new Class1();
            Field.Create_Field();
            Field.Insert_Element('X', 1, 1);
            Field.Insert_Element('O', 1, 1);
            char g = Field.field[0, 0];
            char expected = 'X';
            Assert.AreEqual(expected, g);
        }

        [TestMethod]
        public void TestMethod_FlagCheck()
        {
            Class1 Field = new Class1();
            Field.Create_Field();
            Field.Insert_Element('X', 1, 1);
            Field.Insert_Element('X', 2, 1);
            Field.Insert_Element('X', 3, 1);
            Field.Insert_Element('X', 1, 2);
            Field.Insert_Element('X', 2, 2);
            Field.Insert_Element('X', 3, 2);
            Field.Insert_Element('X', 1, 3);
            Field.Insert_Element('X', 2, 3);
            Field.Insert_Element('X', 3, 3);
            bool expected = false;
            bool f = Field.Flag_Check();
            Assert.AreEqual(expected, f);
        }

        [TestMethod]
        public void TestMethod_GameEnd_1LineWin()
        {
            Class1 Field = new Class1();
            Field.Create_Field();
            Field.Insert_Element('X', 1, 1);
            Field.Insert_Element('X', 2, 1);
            Field.Insert_Element('X', 3, 1);
            bool expected = false;
            bool f = Field.Game_End();
            Assert.AreEqual(expected, f);
        }

        [TestMethod]
        public void TestMethod_GameEnd_LineWin()
        {
            Class1 Field = new Class1();
            Field.Create_Field();
            Field.Insert_Element('X', 1, 3);
            Field.Insert_Element('X', 2, 3);
            Field.Insert_Element('X', 3, 3);
            bool expected = false;
            bool f = Field.Game_End();
            Assert.AreEqual(expected, f);
        }

        [TestMethod]
        public void TestMethod_GameEnd_1ColumnWin()
        {
            Class1 Field = new Class1();
            Field.Create_Field();
            Field.Insert_Element('X', 1, 1);
            Field.Insert_Element('X', 1, 2);
            Field.Insert_Element('X', 1, 3);
            bool expected = false;
            bool f = Field.Game_End();
            Assert.AreEqual(expected, f);
        }

        [TestMethod]
        public void TestMethod_GameEnd_ColumnWin()
        {
            Class1 Field = new Class1();
            Field.Create_Field();
            Field.Insert_Element('X', 3, 1);
            Field.Insert_Element('X', 3, 2);
            Field.Insert_Element('X', 3, 3);
            bool expected = false;
            bool f = Field.Game_End();
            Assert.AreEqual(expected, f);
        }

        [TestMethod]
        public void TestMethod_GameEnd_DiagonalWin()
        {
            Class1 Field = new Class1();
            Field.Create_Field();
            Field.Insert_Element('X', 1, 1);
            Field.Insert_Element('X', 2, 2);
            Field.Insert_Element('X', 3, 3);
            bool expected = false;
            bool f = Field.Game_End();
            Assert.AreEqual(expected, f);
        }

        [TestMethod]
        public void TestMethod_GameEnd_ReverseDiagonalWin()
        {
            Class1 Field = new Class1();
            Field.Create_Field();
            Field.Insert_Element('X', 3, 1);
            Field.Insert_Element('X', 2, 2);
            Field.Insert_Element('X', 1, 3);
            bool expected = false;
            bool f = Field.Game_End();
            Assert.AreEqual(expected, f);
        }
    }
}
