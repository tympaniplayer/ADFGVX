using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ADFGVX.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var obfuscator = new ADFGVX("code");

            var cipherText = obfuscator.EncryptMessage("hello world");

            var plainText = obfuscator.DecryptMessage(cipherText);

            Assert.AreEqual("HELLOWORLD", plainText);
        }
        [TestMethod]
        public void TestLongExample()
        {
            var obfuscator = new ADFGVX("calf");
            
            var cipherText = obfuscator.EncryptMessage("Bradford County 4H leaders and the bradford county holstein club have joined forces again this year to plan and organize a 4h" +
                " heifer sale stop Our goal is to sell 70 calves and heifers along with some semen feed etc stop if you are interested in consigning a calf or heifer please contact gary hennip stop");

            var plainText = obfuscator.DecryptMessage(cipherText);


        }
    }
}
