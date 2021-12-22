using Xunit;
using System;

namespace calc_test
{
    
    public class BasicTest
    {
        const int ARRAYSIZE = 239478;
        double[] array0;
        double[] array1;
        
        [Fact]
        public void TestAddition()
        {
            Assert.Equal(5, Calculator.Addition(1,4));
            
        }
        [Fact]
        public void TestArrayAddition()
        {
            array0 = new double[ARRAYSIZE];
            array1 = new double[ARRAYSIZE];
            for (int i = 0; i < ARRAYSIZE; i++)
            {
                array0[i] = i;
                array1[i] = i + 1;
            }
            for (int i = 0; i < ARRAYSIZE; i++)
            {
                Assert.Equal(i + i + 1, Calculator.Addition(array0[i], array1[i]));
            }
        }
        [Fact]
        public void TestVariableAndArrayAddition()
        {
            array0 = new double[ARRAYSIZE];
            for (int i = 0; i < ARRAYSIZE; i++)
            {
                array0[i] = i;
            }
            for (int i = 0; i < ARRAYSIZE; i++)
            {
                Assert.Equal(i + 5, Calculator.Addition(array0[i], 5));
            }
        }
        [Fact]
        public void TestMultiplication()
        {
            Assert.Equal(5, Calculator.Multiplication(5, 1));
        }
        [Fact]
        public void TestSubtraction()
        {
            Assert.Equal(5, Calculator.Subtraction(9, 4));
        }
        [Fact]
        public void TestArraySubtraction()
        {
            array0 = new double[ARRAYSIZE];
            array1 = new double[ARRAYSIZE];
            for (int i = 0; i < ARRAYSIZE; i++)
            {
                array0[i] = i;
                array1[i] = i + 1;
            }
            for (int i = 0; i < ARRAYSIZE; i++)
            {
                Assert.Equal(1, Calculator.Subtraction(array1[i], array0[i]));
            }
        }
        [Fact]
        public void TestArrayAndVariableSubtraction()
        {
            array0 = new double[ARRAYSIZE];
            for (int i = 0; i < ARRAYSIZE; i++)
            {
                array0[i] = i;
            }
            for (int i = 0; i < ARRAYSIZE; i++)
            {
                Assert.Equal(array0[i]-5, Calculator.Subtraction(array0[i], 5));
            }
        }
        [Fact]
        public void TestVariableAndArraySubtraction()
        {
            array0 = new double[ARRAYSIZE];
            for (int i = 0; i < ARRAYSIZE; i++)
            {
                array0[i] = i;
            }
            for (int i = 0; i < ARRAYSIZE; i++)
            {
                Assert.Equal(5 - array0[i], Calculator.Subtraction(5, array0[i]));
            }
        }
        [Fact]
        public void TestDivision()
        {
            Assert.Equal(5, Calculator.Division(5, 1));

        }
    }
    public class Division0Test {
        [Fact]
        public void TestDivision()
        {
            Assert.Equal(double.NaN, Calculator.Division(5, 0));

        }
    }
}