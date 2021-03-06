﻿using AutumnBox.Leafx.Enhancement.ClassTextKit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace AutumnBox.Tests.Leafx
{
    [TestClass]
    [ClassText(TEST_1_KEY, TEST_1_DFT_VALUE, TEST_1_CHINESE_VALUE)]
    public class ClassTextTest
    {
        private const string TEST_1_KEY = "k_dtt";
        private const string TEST_1_DFT_VALUE = "Hello!My Dream!";
        private const string TEST_1_CHINESE_VALUE = "zh-CN:你好！我的梦！";
        [TestMethod]
        public void DefaultTextTest()
        {
            var reader = ClassTextReader.GetReader<ClassTextTest>();

            Assert.IsTrue(reader[TEST_1_KEY] == TEST_1_DFT_VALUE);
            Assert.IsTrue(reader[TEST_1_KEY, "zh-CN"] == "你好！我的梦！");

            Assert.IsTrue(reader.Get(TEST_1_KEY) == TEST_1_DFT_VALUE);
            Assert.IsTrue(reader.Get(TEST_1_KEY, "zh-CN") == "你好！我的梦！");

            Assert.IsTrue(reader.Get(TEST_1_KEY, "zh-cn") == "你好！我的梦！");
        }
    }
}
