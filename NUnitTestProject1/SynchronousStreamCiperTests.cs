﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace LSFR.Tests
{
    class SynchronousStreamCiperTests
    {


        [TestCase("11101001", "0010", "1001", "10010011")]
        [TestCase("11101001", "0011", "0110", "01010000")]
        [TestCase("1101011011001100", "110011", "101101", "1100001111110011")]
        [TestCase("1001111111110101", "0110110", "1111000", "1010111001111001")]
        [TestCase("1100111100110110", "10101110", "11100001", "1101000101000000")]

        public void EncodeSynchronousStreamCiper(string input, string startState, string taps, string output)
        {
            var synchronousStreamCipher = new SynchronousStreamCipher(startState, taps);
            var result = synchronousStreamCipher.Encrypt(input);

            Assert.AreEqual(output, result);

        }
        [TestCase("11101001", "0010", "1001", "10010011")]
        [TestCase("11101001", "0011", "0110", "01010000")]
        [TestCase("1101011011001100", "110011", "101101", "1100001111110011")]
        [TestCase("1001111111110101", "0110110", "1111000", "1010111001111001")]
        [TestCase("1100111100110110", "10101110", "11100001", "1101000101000000")]
        public void DecodeSynchronousStreamCiper(string input, string startState, string taps, string output)
        {
            var synchronousStreamCipher = new SynchronousStreamCipher(startState, taps);
            var result = synchronousStreamCipher.Decrypt(input);

            Assert.AreEqual(output, result);

        }
    }
}