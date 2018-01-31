using NUnit.Framework;

namespace Lab16
{
    class Prime
    {
        [Test]
        public static void Prime0()
        {
            int num1 = 4;

            for (int a = 2; a <= num1 / 2; a++)
            {
                if (num1 % a == 0)
                {

                    Assert.AreEqual(num1, num1, "wrong");
                }

            }

        }
    }
}



