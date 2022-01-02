using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ironhelmrepo.Controls;

namespace ironhelmrepo.Controls.Tests
{
    /// <summary>This class contains parameterized unit tests for EncryptDecrypt</summary>
    [TestClass]
    [PexClass(typeof(EncryptDecrypt))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class EncryptDecryptTest
    {

        /// <summary>Test stub for ByteArrayToHexString(Byte[])</summary>
        [PexMethod]
        internal string ByteArrayToHexStringTest(byte[] ba)
        {
            string result = EncryptDecrypt.ByteArrayToHexString(ba);
            return result;
            // TODO: add assertions to method EncryptDecryptTest.ByteArrayToHexStringTest(Byte[])
        }

        /// <summary>Test stub for DecryptText(String)</summary>
        [PexMethod]
        internal string DecryptTextTest([PexAssumeUnderTest] EncryptDecrypt target, string encryptedString)
        {
            string result = target.DecryptText(encryptedString);
            return result;
            // TODO: add assertions to method EncryptDecryptTest.DecryptTextTest(EncryptDecrypt, String)
        }

        /// <summary>Test stub for EncryptText(String)</summary>
        [PexMethod]
        internal string EncryptTextTest([PexAssumeUnderTest] EncryptDecrypt target, string plainText)
        {
            string result = target.EncryptText(plainText);
            return result;
            // TODO: add assertions to method EncryptDecryptTest.EncryptTextTest(EncryptDecrypt, String)
        }

        /// <summary>Test stub for GenerateKeyAndIV()</summary>
        [PexMethod]
        internal void GenerateKeyAndIVTest()
        {
            EncryptDecrypt.GenerateKeyAndIV();
            // TODO: add assertions to method EncryptDecryptTest.GenerateKeyAndIVTest()
        }

        /// <summary>Test stub for get_Instance()</summary>
        [PexMethod]
        internal EncryptDecrypt InstanceGetTest()
        {
            EncryptDecrypt result = EncryptDecrypt.Instance;
            return result;
            // TODO: add assertions to method EncryptDecryptTest.InstanceGetTest()
        }
    }
}
