﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace LSFR.Tests
{
    class CiphertextAutokeyTests
    {
        private CiphertextAutokey _coder;

        [SetUp]
        public void SetUp()
        {
            _coder = new CiphertextAutokey();
        }

        [TestCase("11101001", "0011", "1001", "00110011")]
        [TestCase("11101001", "0011", "0110", "01111000")]
        [TestCase("1101011011001100", "110011", "101101", "1001110010111100")]
        [TestCase("1001111111110101", "0110110", "1111000", "1110011100110110")]
        [TestCase("1100111100110110", "10101110", "11100001", "1011110000001111")]
        public void EncodeCiphertextAutokey(string input, string startState, string taps, string output)
        {

            var result = _coder.Encrypt(input, startState, taps);
            Assert.AreEqual(output, result);

        }

        [TestCase("00110011", "0011", "1001", "11101001")]
        [TestCase("01111000", "0011", "0110", "11101001")]
        [TestCase("1001110010111100", "110011", "101101", "1101011011001100")]
        [TestCase("1110011100110110", "0110110", "1111000", "1001111111110101")]
        [TestCase("1011110000001111", "10101110", "11100001", "1100111100110110")]
        public void DecodeCiphertextAutokey(string input, string startState, string taps, string output)
        {

            var result = _coder.Decrypt(input, startState, taps);
            Assert.AreEqual(output, result);

        }
    }
}