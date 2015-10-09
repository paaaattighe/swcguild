using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WARMUPS;
using NUnit.Framework;
using NUnit.Framework.Constraints;


namespace WarmUpTests
{
    [TestFixture]
    //STRINGS 
    public class StringWarmUpsTest
    {
        //String Warmup 1
        [TestCase("Bob", "Hello Bob!")]
        [TestCase("Alice", "Hello Alice!")]
        public void SayHi(string Input, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.SayHi(Input);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 2
        [TestCase("Hi", "Bye", "HiByeByeHi")]
        [TestCase("Yo", "Alice", "YoAliceAliceYo")]
        [TestCase("What", "Up", "WhatUpUpWhat")]
        public void Abba(string a, string b, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.Abba(a, b);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 3
        [TestCase("i", "Yay", "<i>Yay</i>")]
        [TestCase("i", "Hello", "<i>Hello</i>")]
        [TestCase("cite", "Yay", "<cite>Yay</cite>")]
        public void MakeTags(string tag, string content, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.MakeTags(tag, content);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 4
        [TestCase("<<>>", "Yay", "<<Yay>>")]
        [TestCase("<<>>", "WooHoo", "<<WooHoo>>")]
        [TestCase("[[]]", "word", "[[word]]")]
        public void InsertWord(string tag, string content, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.InsertWord(tag, content);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 5
        [TestCase("Hello", "lololo")]
        [TestCase("ab", "ababab")]
        [TestCase("Hi", "HiHiHi")]
        public void MultipleEndings(string str, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.MultipleEndings(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 6
        [TestCase("WooHoo", "Woo")]
        [TestCase("HelloThere", "Hello")]
        [TestCase("abcdef", "abc")]
        public void FirstHalf(string str, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.FirstHalf(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 7
        [TestCase("Hello", "ell")]
        [TestCase("java", "av")]
        [TestCase("coding", "odin")]
        public void TrimOne(string str, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.TrimOne(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 8
        [TestCase("hello", "hi", "hihellohi")]
        [TestCase("hi", "hello", "hihellohi")]
        [TestCase("aaa", "b", "baaab")]
        public void LongInMiddle(string a, string b, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.LongInMiddle(a, b);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 9
        [TestCase("Hello", "lloHe")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void Rotateleft2(string str, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.Rotateleft2(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 10
        [TestCase("Hello", "loHel")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void RotateRight2(string str, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.RotateRight2(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }


        //String Warmup 11
        [TestCase("Hello", true, "H")]
        [TestCase("Hello", false, "o")]
        [TestCase("oh", true, "o")]
        public void TakeOne(string str, bool fromFront, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.TakeOne(str, fromFront);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 12
        [TestCase("String", "ri")]
        [TestCase("code", "od")]
        [TestCase("Practice", "ct")]
        public void MiddleTwo(string str, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.MiddleTwo(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 13
        [TestCase("oddly", true)]
        [TestCase("oddy", false)]
        [TestCase("y", false)]
        public void EndsWithLy(string str, bool Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            bool result = WarmUp.EndsWithLy(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 14
        [TestCase("Hello", 2, "Helo")]
        [TestCase("Chocolate", 3, "Choate")]
        [TestCase("Chocolate", 1, "Ce")]
        public void FrontAndBack(string str, int n, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.FrontAndBack(str, n);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 15
        [TestCase("java", 0, "ja")]
        [TestCase("java", 2, "va")]
        [TestCase("java", 3, "ja")]
        public void TakeTwoFromPosition(string str, int n, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.TakeTwoFromPosition(str, n);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 16
        [TestCase("badxx", true)]
        [TestCase("xbadxx", true)]
        [TestCase("xxbadxx", false)]
        public void HasBad(string str, bool Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            bool result = WarmUp.HasBad(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 17
        [TestCase("hello", "he")]
        [TestCase("hi", "hi")]
        [TestCase("h", "h@")]
        public void AtFirst(string str, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.AtFirst(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 18
        [TestCase("last", "chars", "ls")]
        [TestCase("yo", "mama", "ya")]
        [TestCase("hi", "", "h@")]
        public void LastChars(string a, string b, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.LastChars(a, b);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 19
        [TestCase("abc", "cat", "abcat")]
        [TestCase("dog", "cat", "dogcat")]
        [TestCase("abc", "", "abc")]
        public void ConCat(string a, string b, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.ConCat(a, b);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 20
        [TestCase("coding", "codign")]
        [TestCase("cat", "cta")]
        [TestCase("ab", "ba")]
        public void SwapLast(string str, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.SwapLast(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }


        //String Warmup 21
        [TestCase("edited", true)]
        [TestCase("edit", false)]
        [TestCase("ed", true)]
        public void FrontAgain(string str, bool Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            bool result = WarmUp.FrontAgain(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 22
        [TestCase("Hello", "Hi", "loHi")]
        [TestCase("Hello", "java", "ellojava")]
        [TestCase("java", "Hello", "javaello")]
        public void MinCat(string a, string b, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.MinCat(a, b);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //String Warmup 23
        [TestCase("Hello", "llo")]
        [TestCase("away", "aay")]
        [TestCase("abed", "abed")]
        public void TweakFront(string str, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.TweakFront(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }


        //String Warmup 24
        [TestCase("xHix", "Hi")]
        [TestCase("xHi", "Hi")]
        [TestCase("Hxix", "Hxi")]
        public void StripX(string str, string Expected)
        {
            //arrange instantiating objects
            StringWarmups WarmUp = new StringWarmups();

            //act Method
            string result = WarmUp.StripX(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //CONDITIONALS

        //Cond Warmup 1
        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        public void AreWeInTrouble(bool aSmile, bool bSmile, bool Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            bool result = WarmUp.AreWeInTrouble(aSmile, bSmile);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Cond Warmup 2
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]
        public void CanSleepIn(bool isWeekday, bool isVacation, bool Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            bool result = WarmUp.CanSleepIn(isWeekday, isVacation);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Cond Warmup 3
        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]
        public void SumDouble(int a, int b, int Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            int result = WarmUp.SumDouble(a, b);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Cond Warmup 4
        [TestCase(23, 4)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]
        public void Diff21(int n, int Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            int result = WarmUp.Diff21(n);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Cond Warmup 5
        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]
        public void ParrotTrouble(bool isTalking, int hour, bool Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            bool result = WarmUp.ParrotTrouble(isTalking, hour);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Cond Warmup 6
        [TestCase(9, 10, true)]
        [TestCase(9, 9, false)]
        [TestCase(1, 9, true)]
        public void Makes10(int a, int b, bool Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            bool result = WarmUp.Makes10(a, b);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Cond Warmup 7
        [TestCase(103, true)]
        [TestCase(90, true)]
        [TestCase(89, false)]
        public void NearHundred(int n, bool Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            bool result = WarmUp.NearHundred(n);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Cond Warmup 8
        [TestCase(1, -1, false, true)]
        [TestCase(-1, 1, false, true)]
        [TestCase(-4, -5, true, true)]
        public void PosNeg(int a, int b, bool negative, bool Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            bool result = WarmUp.PosNeg(a, b, negative);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        // Cond Warmup 9
        [TestCase("candy", "not candy")]
        [TestCase("x", "not x")]
        [TestCase("not bad", "not bad")]
        public void NotString(string s, string Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            string result = WarmUp.NotString(s);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        // Cond Warmup 10
        [TestCase("kitten", 1, "ktten")]
        [TestCase("kitten", 0, "itten")]
        [TestCase("kitten", 4, "kittn")]
        public void MissingChar(string str, int n, string Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            string result = WarmUp.MissingChar(str, n);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        // Cond Warmup 11
        [TestCase("code", "eodc")]
        [TestCase("a", "a")]
        [TestCase("ab", "ba")]
        public void FrontBack(string str, string Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            string result = WarmUp.FrontBack(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        // Cond Warmup 12
        [TestCase("Microsoft", "MicMicMic")]
        [TestCase("Chocolate", "ChoChoCho")]
        [TestCase("at", "atatat")]
        public void Front3(string str, string Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            string result = WarmUp.Front3(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Cond Warmup 13
        [TestCase("cat", "tcatt")]
        [TestCase("Hello", "oHelloo")]
        [TestCase("a", "aaa")]
        public void BackAround(string str, string Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            string result = WarmUp.BackAround(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Cond Warmup 14
        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(8, false)]
        public void Multiple3or5(int number, bool Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            bool result = WarmUp.Multiple3or5(number);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Cond Warmup 15
        [TestCase("hi there", true)]
        [TestCase("hi", true)]
        [TestCase("high up", false)]
        public void StartHi(string str, bool Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            bool result = WarmUp.StartHi(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Cond Warmup 16
        [TestCase(120, -1, true)]
        [TestCase(-1, 120, true)]
        [TestCase(2, 120, false)]
        public void IcyHot(int temp1, int temp2, bool Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            bool result = WarmUp.IcyHot(temp1, temp2);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Cond Warmup 17
        [TestCase(12, 99, true)]
        [TestCase(21, 12, true)]
        [TestCase(8, 99, false)]
        public void Between10and20(int a, int b, bool Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            bool result = WarmUp.Between10and20(a, b);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Cond Warmup 18
        [TestCase(13, 20, 10, true)]
        [TestCase(20, 19, 10, true)]
        [TestCase(20, 10, 12, false)]
        public void HasTeen(int a, int b, int c, bool Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            bool result = WarmUp.HasTeen(a, b, c);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Cond Warmup 19
        [TestCase(13, 99, true)]
        [TestCase(21, 19, true)]
        [TestCase(13, 13, false)]
        public void SoAlone(int a, int b, bool Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            bool result = WarmUp.SoAlone(a, b);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Cond Warmup 20
        [TestCase("adelbc", "abc")]
        [TestCase("adelHello", "aHello")]
        [TestCase("adedbc", "adedbc")]
        public void RemoveDel(string str, string Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            string result = WarmUp.RemoveDel(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }


        //Cond Warmup 21
        [TestCase("mix snacks", true)]
        [TestCase("pix snacks", true)]
        [TestCase("piz snacks", false)]
        public void IxStart(string str, bool Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            bool result = WarmUp.IxStart(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Cond Warmup 22
        [TestCase("ozymandias", "oz")]
        [TestCase("bzoo", "z")]
        [TestCase("oxx", "o")]
        public void StartOz(string str, string Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            string result = WarmUp.StartOz(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Cond Warmup 23
        [TestCase(1, 2, 3, 3)]
        [TestCase(1, 3, 2, 3)]
        [TestCase(3, 2, 1, 3)]
        public void Max(int a, int b, int c, int Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            int result = WarmUp.Max(a, b, c);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Cond Warmup 24
        [TestCase(8, 13, 8)]
        [TestCase(13, 8, 8)]
        [TestCase(13, 7, 0)]
        public void Closer(int a, int b, int Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            int result = WarmUp.Closer(a, b);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }


        //Cond Warmup 25
        [TestCase("Hello", true)]
        [TestCase("Heelle", true)]
        [TestCase("Heelele", false)]
        public void GotE(string str, bool Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            bool result = WarmUp.GotE(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        } 

        // Cond Warmup 26
        [TestCase("Hello", "HeLLO")]
        [TestCase("hi there", "hi thERE")]
        [TestCase("hi", "HI")]
        public void EndUp(string str, string Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            string result = WarmUp.EndUp(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Cond Warmup 27
        [TestCase("Miracle", 2, "Mrce")]
        [TestCase("abcdefg", 2, "aceg")]
        [TestCase("abcdefg", 3, "adg")]
        public void EveryNth(string str, int n, string Expected)
        {
            //arrange instantiating objects
            ConditionalWarmups WarmUp = new ConditionalWarmups();

            //act Method
            string result = WarmUp.EveryNth(str, n);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }




        //Logic Warmup 1
        [TestCase(30, false, false)]
        [TestCase(50, false, true)]
        [TestCase(70, true, true)]
        public void GreatParty(int cigars, bool isWeekend, bool Expected)
        {
            //arrange instantiating objects
            LogicWarmups WarmUp = new LogicWarmups();

            //act Method
            bool result = WarmUp.GreatParty(cigars, isWeekend);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Logic Warmup 2
        [TestCase(5, 10, 2)]
        [TestCase(5, 2, 0)]
        [TestCase(5, 5, 1)]
        public void CanHazTable(int yourStyle, int dateStyle, int Expected)
        {
            //arrange instantiating objects
            LogicWarmups WarmUp = new LogicWarmups();

            //act Method
            int result = WarmUp.CanHazTable(yourStyle, dateStyle);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }
        
        //Logic Warmup 3
        [TestCase(70, false, true)]
        [TestCase(95, false, false)]
        [TestCase(95, true, true)]
        public void PlayOutside(int temp, bool isSummer, bool Expected)
        {
            //arrange instantiating objects
            LogicWarmups WarmUp = new LogicWarmups();

            //act Method
            bool result = WarmUp.PlayOutside(temp, isSummer);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Logic Warmup 4
        [TestCase(60, false, 0)]
        [TestCase(65, false, 1)]
        [TestCase(65, true, 0)]
        public void CaughtSpeeding(int speed, bool isBirthday, int Expected)
        {
            //arrange instantiating objects
            LogicWarmups WarmUp = new LogicWarmups();

            //act Method
            int result = WarmUp.CaughtSpeeding(speed, isBirthday);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Logic Warmup 5
        [TestCase(3, 4, 7)]
        [TestCase(9, 4, 20)]
        [TestCase(10, 11, 21)]
        public void SkipSum(int a, int b, int Expected)
        {
            //arrange instantiating objects
            LogicWarmups WarmUp = new LogicWarmups();

            //act Method
            int result = WarmUp.SkipSum(a, b);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Logic Warmup 6
        [TestCase(1, false, "7:00")]
        [TestCase(5, false, "7:00")]
        [TestCase(0, false, "10:00")]
        public void AlarmClock(int day, bool vacation, string Expected)
        {
            //arrange instantiating objects
            LogicWarmups WarmUp = new LogicWarmups();

            //act Method
            string result = WarmUp.AlarmClock(day, vacation);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Logic Warmup 7
        [TestCase(6, 4, true)]
        [TestCase(4, 5, false)]
        [TestCase(1, 5, true)]
        public void LoveSix(int a, int b, bool Expected)
        {
            //arrange instantiating objects
            LogicWarmups WarmUp = new LogicWarmups();

            //act Method
            bool result = WarmUp.LoveSix(a, b);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Logic Warmup 8
        [TestCase(5, false, true)]
        [TestCase(11, false, false)]
        [TestCase(11, true, true)]
        public void InRange(int n, bool outsideMode, bool Expected)
        {
            //arrange instantiating objects
            LogicWarmups WarmUp = new LogicWarmups();

            //act Method
            bool result = WarmUp.InRange(n, outsideMode);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Logic Warmup 9
        [TestCase(22, true)]
        [TestCase(23, true)]
        [TestCase(24, false)]
        public void SpecialEleven(int n, bool Expected)
        {
            //arrange instantiating objects
            LogicWarmups WarmUp = new LogicWarmups();

            //act Method
            bool result = WarmUp.SpecialEleven(n);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Logic Warmup 10
        [TestCase(20, false)]
        [TestCase(21, true)]
        [TestCase(22, true)]
        public void Mod20(int n, bool Expected)
        {
            //arrange instantiating objects
            LogicWarmups WarmUp = new LogicWarmups();

            //act Method
            bool result = WarmUp.Mod20(n);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Logic Warmup 11
        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(15, false)]
        public void Mod35(int n, bool Expected)
        {
            //arrange instantiating objects
            LogicWarmups WarmUp = new LogicWarmups();

            //act Method
            bool result = WarmUp.Mod35(n);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Logic Warmup 12
        [TestCase(false, false, false, true)]
        [TestCase(false, false, true, false)]
        [TestCase(true, false, false, false)]
        public void AnswerCell(bool isMorning, bool isMom, bool isAsleep, bool Expected)
        {
            //arrange instantiating objects
            LogicWarmups WarmUp = new LogicWarmups();

            //act Method
            bool result = WarmUp.AnswerCell(isMorning, isMom, isAsleep);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Logic Warmup 13
        [TestCase(1, 2, 3, true)]
        [TestCase(3, 1, 2, true)]
        [TestCase(3, 2, 2, false)]
        public void TwoIsOne(int a, int b, int c, bool Expected)
        {
            //arrange instantiating objects
            LogicWarmups WarmUp = new LogicWarmups();

            //act Method
            bool result = WarmUp.TwoIsOne(a, b, c);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Logic Warmup 14
        [TestCase(1, 2, 4, false, true)]
        [TestCase(1, 2, 1, false, false)]
        [TestCase(1, 1, 2, true, true)]
        public void AreInOrder(int a, int b, int c, bool bOk, bool Expected)
        {
            //arrange instantiating objects
            LogicWarmups WarmUp = new LogicWarmups();

            //act Method
            bool result = WarmUp.AreInOrder(a, b, c, bOk);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Logic Warmup 15
        [TestCase(2, 5, 11, false, true)]
        [TestCase(5, 7, 6, false, false)]
        [TestCase(5, 5, 7, true, true)]
        public void InOrderEqual(int a, int b, int c, bool equal10k, bool Expected)
        {
            //arrange instantiating objects
            LogicWarmups WarmUp = new LogicWarmups();

            //act Method
            bool result = WarmUp.InOrderEqual(a, b, c, equal10k);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Logic Warmup 16
        [TestCase(23, 19, 13, true)]
        [TestCase(23, 19, 12, false)]
        [TestCase(23, 19, 3, true)]
        public void LastDigit(int a, int b, int c, bool Expected)
        {
            //arrange instantiating objects
            LogicWarmups WarmUp = new LogicWarmups();

            //act Method
            bool result = WarmUp.LastDigit(a, b, c);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Logic Warmup 17
        [TestCase(2, 3, true, 5)]
        [TestCase(3, 3, true, 7)]
        [TestCase(3, 3, false, 6)]
        public void RollDice(int die1, int die2, bool noDoubles, int Expected)
        {
            //arrange instantiating objects
            LogicWarmups WarmUp = new LogicWarmups();

            //act Method
            int result = WarmUp.RollDice(die1, die2, noDoubles);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Array Warmup 1
        [TestCase(new int[] {1, 2, 6}, true)]
        [TestCase(new int[] { 6, 1, 2, 3}, true)]
        [TestCase(new int[] { 13, 6, 1, 2, 3}, false)]
        public void FirstLast6(int[] numbers, bool Expected)
        {
            //arrange instantiating objects
            ArrayWarmups WarmUp = new ArrayWarmups();

            //act Method
            bool result = WarmUp.FirstLast6(numbers);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Array Warmup 2
        [TestCase(new int[] {1, 2, 3}, false)]
        [TestCase(new int[] {1, 2, 3, 1}, true)]
        [TestCase(new int[] {1, 2, 1}, true)]
        public void SameFirstLast(int[] numbers, bool Expected)
        {
            //arrange instantiating objects
            ArrayWarmups WarmUp = new ArrayWarmups();

            //act Method
            bool result = WarmUp.SameFirstLast(numbers);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Array Warmup 3
        [TestCase(3, new int[] { 3, 1, 4 })]
        public void MakePi(int n, int[] Expected)
        {
            //arrange instantiating objects
            ArrayWarmups WarmUp = new ArrayWarmups();

            //act Method
            int[] result = WarmUp.MakePi(n);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }


        //Array Warmup 4
        [TestCase(new int[] { 1, 2, 3}, new int[] {7, 3}, true)]
        [TestCase(new int[] { 1, 2, 3}, new int[] {7, 3, 2}, false)]
        [TestCase(new int[] { 1, 2, 3}, new int[] {1, 3}, true)]
        public void commonEnd(int[] a, int[] b, bool Expected)
        {
            //arrange instantiating objects
            ArrayWarmups WarmUp = new ArrayWarmups();

            //act Method
            bool result = WarmUp.commonEnd(a, b);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Array Warmup 5
        [TestCase( new int[] { 1,2,3 }, 6)]
        [TestCase(new int[] { 5, 11, 2 }, 18)]
        [TestCase(new int[] { 7,0,0 }, 7)]
        public void Sum(int[] numbers, int Expected)
        {
            //arrange instantiating objects
            ArrayWarmups WarmUp = new ArrayWarmups();

            //act Method
            int result = WarmUp.Sum(numbers);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Array Warmup 6
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3, 1 })]
        [TestCase(new int[] { 5, 11, 9 }, new int[] { 11, 9, 5 })]
        [TestCase(new int[] { 7, 0, 0 }, new int[] { 0, 0, 7 })]
        public void RotateLeft(int[] numbers, int[] Expected)
        {
            //arrange instantiating objects
            ArrayWarmups WarmUp = new ArrayWarmups();

            //act Method
            int[] result = WarmUp.RotateLeft(numbers);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Array Warmup 7
        [TestCase(new int[] { 1,2,3}, new int[] {3, 2, 1})]
        public void Reverse(int[] numbers, int[] Expected)
        {
            //arrange instantiating objects
            ArrayWarmups WarmUp = new ArrayWarmups();

            //act Method
            int[] result = WarmUp.Reverse(numbers);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Array Warmups 8
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3,3,3})]
        [TestCase(new int[] {11, 5, 9 }, new int[] { 11, 11,11})]
        [TestCase(new int[] { 2, 11, 3 }, new int[] { 3,3,3 })]
        public void HigherWins(int[] numbers, int[] Expected)
        {
            //arrange instantiating objects
            ArrayWarmups WarmUp = new ArrayWarmups();

            //act Method
            int[] result = WarmUp.HigherWins(numbers);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Array Warmups 9
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4,5,6 }, new int[] {2, 5})]
        [TestCase(new int[] { 7,7,7 }, new int[] { 3, 8,0}, new int[] {7,8})]
        [TestCase(new int[] { 5,2,9}, new int[] {1, 4, 5}, new int[] {2, 4})]
        public void GetMiddle(int[] a, int[] b, int[] Expected)
        {
            //arrange instantiating objects
            ArrayWarmups WarmUp = new ArrayWarmups();

            //act Method
            int[] result = WarmUp.GetMiddle(a, b);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Array Warmups 10
        [TestCase(new int[] { 2,5 }, true)]
        [TestCase(new int[] { 4,3 },true)]
        [TestCase(new int[] { 7, 5}, false)]
        public void HasEven(int[] numbers, bool Expected)
        {
            //arrange instantiating objects
            ArrayWarmups WarmUp = new ArrayWarmups();

            //act Method
            bool result = WarmUp.HasEven(numbers);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Arrays Warmups 11
        [TestCase(new int[] { 4, 5, 6 }, new int[] { 0, 0, 0, 0, 0, 6 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 0, 0, 0, 2 })]
        [TestCase(new int[] { 3 }, new int[] { 0, 3 })]
        public void KeepLast(int[] numbers, int[] Expected)
        {
            //arrange instantiating objects
            ArrayWarmups WarmUp = new ArrayWarmups();

            //act Method
            int[] result = WarmUp.KeepLast(numbers);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Arrays Warmups 12
        [TestCase(new int[] { 2, 2, 3 }, true)]
        [TestCase(new int[] { 3, 4, 5, 3 }, true)]
        [TestCase(new int[] { 2, 3, 2, 2 }, false)]
        public void Double23(int[] numbers, bool Expected)
        {
            //arrange instantiating objects
            ArrayWarmups WarmUp = new ArrayWarmups();

            //act Method
            bool result = WarmUp.Double23(numbers);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }


        //Arrays Warmups 13
        [TestCase(new int[] { 1, 2, 3}, new int[] { 1, 2, 0 })]
        [TestCase(new int[] { 2, 3, 5 }, new int[] { 2, 0, 5 })]
        [TestCase(new int[] {1, 2, 1}, new int[] {1, 2, 1})]
        public void Fix23(int[] numbers, int[] Expected)
        {
            //arrange instantiating objects
            ArrayWarmups WarmUp = new ArrayWarmups();

            //act Method
            int[] result = WarmUp.Fix23(numbers);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }


        //Arrays Warmups 14
        [TestCase(new int[] { 1, 3, 4, 5 }, true)]
        [TestCase(new int[] { 2, 1, 3, 4, 5 }, true)]
        [TestCase(new int[] { 1, 1, 1 }, false)]
        public void Unlucky1(int[] numbers, bool Expected)
        {
            //arrange instantiating objects
            ArrayWarmups WarmUp = new ArrayWarmups();

            //act Method
            bool result = WarmUp.Unlucky1(numbers);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Arrays Warmups 15
        [TestCase(new int[] {4,5}, new int[] { 1, 2, 3 }, new int[] { 4,5})]
        [TestCase(new int[] { 4 }, new int[] {1,2,3}, new int[] { 4,1 })]
        [TestCase(new int[] {}, new int[] {1,2}, new int[] { 1, 2})]
        public void make2(int[] a, int[] b, int[] Expected)
        {
            //arrange instantiating objects
            ArrayWarmups WarmUp = new ArrayWarmups();

            //act Method
            int[] result = WarmUp.make2(a, b);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }
    }
    class LoopWarmupTests
    {
        //Loop Warmups 1
        [TestCase("Hi", 2, "HiHi")]
        [TestCase("Hi", 3, "HiHiHi")]
        [TestCase("Hi", 1, "Hi")]
        public void StringTimes(string str, int n, string Expected)
        {
            //arrange instantiating objects
            LoopWarmups WarmUp = new LoopWarmups();

            //act Method
            string result = WarmUp.StringTimes(str, n);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }


        //Loop Warmups 2
        [TestCase("Chocolate", 2, "ChoCho")]
        [TestCase("Chocolate", 3, "ChoChoCho")]
        [TestCase("Abc", 3, "AbcAbcAbc")]
        public void FrontTimes(string str, int n, string Expected)
        {
            //arrange instantiating objects
            LoopWarmups WarmUp = new LoopWarmups();

            //act Method
            string result = WarmUp.FrontTimes(str, n);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Loop Warmups 3
        [TestCase("abcxx", 1)]
        [TestCase("xxx", 2)]
        [TestCase("xxxx", 3)]
        public void CountXX(string str, int Expected)
        {
            //arrange instantiating objects
            LoopWarmups WarmUp = new LoopWarmups();

            //act Method
            int result = WarmUp.CountXX(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Loop Warmups 4
        [TestCase("axxbb", true)]
        [TestCase("axaxxax", false)]
        [TestCase("xxxxx", true)]
        public void DoubleX(string str, bool Expected)
        {
            //arrange instantiating objects
            LoopWarmups WarmUp = new LoopWarmups();

            //act Method
            bool result = WarmUp.DoubleX(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Loop Warmups 5
        [TestCase("Hello", "Hlo")]
        [TestCase("Hi", "H")]
        [TestCase("Heeololeo", "Hello")]
        public void EveryOther(string str, string Expected)
        {
            //arrange instantiating objects
            LoopWarmups WarmUp = new LoopWarmups();

            //act Method
            string result = WarmUp.EveryOther(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Loop Warmups 6
        [TestCase("Code", "CCoCodCode")]
        [TestCase("abc", "aababc")]
        [TestCase("ab", "aab")]
        public void StringSplosion(string str, string Expected)
        {
            //arrange instantiating objects
            LoopWarmups WarmUp = new LoopWarmups();

            //act Method
            string result = WarmUp.StringSplosion(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Loop Warmups 7
        [TestCase("hixxhi", 1)]
        [TestCase("xaxxaxaxx", 1)]
        [TestCase("axxxaaxx", 2)]
        public void CountLast2(string str, int Expected)
        {
            //arrange instantiating objects
            LoopWarmups WarmUp = new LoopWarmups();

            //act Method
            int result = WarmUp.CountLast2(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Loop Warmups 8
        [TestCase(new int[] { 1, 2, 9 }, 1)]
        [TestCase(new int[] { 1, 9, 9 }, 2)]
        [TestCase(new int[] { 1, 9, 9, 3, 9 }, 3)]
        public void Count9(int[] numbers, int Expected)
        {
            //arrange instantiating objects
            LoopWarmups WarmUp = new LoopWarmups();

            //act Method
            int result = WarmUp.Count9(numbers);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Loop Warmup 9 
        [TestCase(new int[] { 1, 2, 9, 3, 4 }, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 9 }, false)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, false)]
        public void ArrayFront9(int[] numbers, bool Expected)
        {
            //arrange instantiating objects
            LoopWarmups WarmUp = new LoopWarmups();

            //act Method
            bool result = WarmUp.ArrayFront9(numbers);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Loop Warmup 10
        [TestCase(new int[] { 1, 1, 2, 3, 1 }, true)]
        [TestCase(new int[] { 1, 1, 2, 4, 1 }, false)]
        [TestCase(new int[] { 1, 1, 2, 1, 2, 3 }, true)]
        public void Array123(int[] numbers, bool Expected)
        {
            //arrange instantiating objects
            LoopWarmups WarmUp = new LoopWarmups();

            //act Method
            bool result = WarmUp.Array123(numbers);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Loop Warmups 11
        [TestCase("xxcaazz", "xxbaaz", 3)]
        [TestCase("abc", "abc", 2)]
        [TestCase("abc", "axc", 0)]
        public void SubstringMatch(string a, string b, int Expected)
        {
            //arrange instantiating objects
            LoopWarmups WarmUp = new LoopWarmups();

            //act Method
            int result = WarmUp.SubStringMatch(a, b);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Loop Warmups 12
        [TestCase("xxHxix", "xHix")]
        [TestCase("abxxxcd", "abcd")]
        [TestCase("xabxxxcdx", "xabcdx")]
        public void StringX(string str, string Expected)
        {
            //arrange instantiating objects
            LoopWarmups WarmUp = new LoopWarmups();

            //act Method
            string result = WarmUp.StringX(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Loop Warmups 13
        [TestCase("kitten", "kien")]
        [TestCase("Chocolate", "Chole")]
        [TestCase("CodingHorror", "Congrr")]
        public void AltPairs(string str, string Expected)
        {
            //arrange instantiating objects
            LoopWarmups WarmUp = new LoopWarmups();

            //act Method
            string result = WarmUp.AltPairs(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Loop Warmups 14
        [TestCase("yakpak", "pak")]
        [TestCase("pakyak", "pak")]
        [TestCase("yak123ya", "123ya")]
        public void DoNotYak(string str, string Expected)
        {
            //arrange instantiating objects
            LoopWarmups WarmUp = new LoopWarmups();

            //act Method
            string result = WarmUp.DoNotYak(str);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Loop Warmups 15
        [TestCase(new int[] { 6, 6, 2 }, 1)]
        [TestCase(new int[] { 6, 6, 2, 6 }, 1)]
        [TestCase(new int[] { 6, 7, 2, 6 }, 1)]
        public void Array667(int[] numbers, int Expected)
        {
            //arrange instantiating objects
            LoopWarmups WarmUp = new LoopWarmups();

            //act Method
            int result = WarmUp.Array667(numbers);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Loop Warmups 16
        [TestCase(new int[] { 1, 1, 2, 2, 1 }, true)]
        [TestCase(new int[] { 1, 1, 2, 2, 2, 1 }, false)]
        [TestCase(new int[] { 1, 1, 1, 2, 2, 2, 1 }, false)]
        public void NoTriples(int[] numbers, bool Expected)
        {
            //arrange instantiating objects
            LoopWarmups WarmUp = new LoopWarmups();

            //act Method
            bool result = WarmUp.NoTriples(numbers);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }

        //Loop Warmup 17
        [TestCase(new int[] { 1, 2, 7, 1 }, true)]
        [TestCase(new int[] { 1, 2, 8, 1 }, false)]
        [TestCase(new int[] { 2, 7, 1 }, true)]
        public void Pattern51(int[] numbers, bool Expected)
        {
            //arrange instantiating objects
            LoopWarmups WarmUp = new LoopWarmups();

            //act Method
            bool result = WarmUp.Pattern51(numbers);

            //assert testing result
            Assert.AreEqual(Expected, result);
        }
    }
}
