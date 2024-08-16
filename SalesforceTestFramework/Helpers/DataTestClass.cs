using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

public class DataTestClass
{
    private Random _random;

    public DataTestClass()
    {
        _random = new Random();
    }

    public static string GetString(IEnumerable<object[]> objects)
    {
        return RandomData.ToString();
    }

    public static IEnumerable<string[]> RandomData
    {
        get
        {
            var random = new Random();
           // for (int i = 0; i < 5; i++) // Генерируем 5 наборов данных
            {
                yield return new string[]
                {
                    GenerateRandomString(random, 8), // Случайная строка длиной 8
                };
            }
        }
    }

    private static string GenerateRandomString(Random random, int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        char[] stringChars = new char[length];

        for (int i = 0; i < length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
        }

        return new string(stringChars);
    }
}




/*using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class DataTestClass
{
    private Random _random;

    public DataTestClass()
    {
        _random = new Random();
    }

    public static IEnumerable<object[]> RandomData
    {
        get
        {
            var random = new Random();
            for (int i = 0; i < 5; i++) // Генерируем 5 наборов данных
            {
                yield return new object[]
                {
                    GenerateRandomString(random, 8), // Случайная строка длиной 8
                    random.Next(1, 100) // Случайное число от 1 до 99
                };
            }
        }
    }

    private static string GenerateRandomString(Random random, int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        char[] stringChars = new char[length];

        for (int i = 0; i < length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
        }

        return new string(stringChars);
    }

    [TestMethod]
    [DynamicData(nameof(RandomData), DynamicDataSourceType.Property)]
    public void TestWithRandomData(string randomString, int randomNumber)
    {
        // Здесь можно использовать randomString и randomNumber для тестирования
        Console.WriteLine($"Тестовые данные: {randomString}, {randomNumber}");
        Assert.IsNotNull(randomString);
        Assert.IsTrue(randomNumber > 0);
    }
}
*/