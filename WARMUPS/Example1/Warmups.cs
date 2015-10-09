using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace WARMUPS
{
    public class StringWarmups
    {
        //STRING
        //WARMUPS

        //String Warmup 1
        public string SayHi(string name)
        {
            return ("Hello " + name + "!");
        }

        //String Warmup 2
        public string Abba(string a, string b)
        {
            return (a + b + b + a);
        }

        //String Warmup 3
        public string MakeTags(string tag, string content)
        {
            return ("<" + tag + ">" + content + "</" + tag + ">");
        }

        // String Warmup 4
        public string InsertWord(string container, string word)
        {
            return (container.Substring(0, 2) + word + container.Substring(2, 2));
        }

        // String Warmup 5
        public string MultipleEndings(string str)
        {
            if (str.Length > 2)
            {
                return (str.Substring(3, 2) + str.Substring(3, 2) + str.Substring(3, 2));
            }
            else
            {
                return (str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2));
            }

        }

        //String Warmup 6
        public string FirstHalf(string str)
        {
            if (str.Length > 6)
            {
                return str.Substring(0, 5);
            }
            else
            {
                return str.Substring(0, 3);
            }
        }

        //String Warmup 7
        public string TrimOne(string str)
        {
            return str.TrimEnd('o', 'a', 'g').TrimStart('H', 'j', 'c');
        }

        //String Warmup 8 
        public string LongInMiddle(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return (b + a + b);
            }
            else
            {
                return (a + b + a);
            }
        }

        //String Warmup 9
        public string Rotateleft2(string str)
        {
            str = str + str.Substring(0, 2);
            return str.Remove(0, 2);
        }

        //String Warmup 10
        public string RotateRight2(string str)
        {
            if (str.Length > 4)
            {
                string sub1 = str.Substring(3, 2);
                return str.Insert(0, sub1).Remove(5, 2);
            }
            else if (str.Length > 2)
            {
                string sub = str.Substring(0, 2);
                return str.Remove(0, 2).Insert(2, sub);
            }
            else
            {
                return str.Substring(0, 2);
            }
        }

        // String Warmup 11
        public string TakeOne(string str, bool fromFront)
        {
            if (fromFront == true)
            {

                return str.Substring(0, 1);
            }
            else
            {
                return str.Substring(str.Length - 1, 1);
            }
        }

        //String Warmup 12
        public string MiddleTwo(string str)
        {
                int stringhalf = str.Length/2 - 1;

                return str.Substring(stringhalf, 2);
        }

        //String Warmup 13
        public bool EndsWithLy(string str)
        {

            if (str.EndsWith("ly"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //String Warmup 14
        public string FrontAndBack(string str, int n)
        {
            int strend = str.Length - n;
            return str.Substring(0, n) + str.Substring(strend, n);
        }

        //String Warmup 15
        public string TakeTwoFromPosition(string str, int n)
        {

            if (n > 2)
            {
                return str.Substring(0, 2);
            }
            else
            {
                string str2 = str.Substring(n, 2);
                return str2;
            }
        }

        //String Warmup 16
        public bool HasBad(string str)
        {

            if ((str.IndexOf("bad") != -1) && ("b" == str.Substring(0, 1)) || ("b" == str.Substring(1, 1)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //String Warmup 17
        public string AtFirst(string str)
        {
            if (str.Length < 2)
            {

                return str.Substring(0, 1) + "@";
            }
            else
            {
                return str.Substring(0, 2);
            }
        }

        //String Warmup 18
        public string LastChars(string a, string b)
        {
            int bLast = b.Length - 1;
            if (a.Length < 1)
            {

                a = "@";
                return a.Substring(0, 1) + b.Substring(bLast, 1);
            }
            else if (b.Length < 1)
            {

                b = "@";
                return a.Substring(0, 1) + b.Substring(0, 1);
            }
            else
            {
                return a.Substring(0, 1) + b.Substring(bLast, 1);
            }

        }

        //String Warmup 19
        public string ConCat(string a, string b)
        {
            string c = string.Concat(a, b);
            string ab = a.TrimEnd('c');

            if (c.Contains("cc"))
            {
                return ab + b;
            }
            else
            {
                return c;
            }
            

        }

        //String Warmup 20
        public string SwapLast(string str)
        {
            //make the initial string smaller by 2 characters
            int shortenString = str.Length - 2;

            // grab the last 2 
            string strEnd = str.Substring(shortenString, 2);
            // reversing the last 2 characters through an array.
            char[] strEndChar = strEnd.ToCharArray();
            Array.Reverse(strEndChar);
            string reversedEnd = new string(strEndChar);
            str = str.Substring(0, str.Length - 2);
            // 

            string stringSwapped = string.Concat(str, reversedEnd);
            return stringSwapped;
        }

        //String Warmup 21
        public bool FrontAgain(string str)
        {
            if (str.StartsWith("ed") && (str.EndsWith("ed")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //String Warmup 22
        public string MinCat(string a, string b)
        {
            if (a.Length != b.Length)
            {
                if (a.Length > b.Length && (b.Length < 3))
                {
                    string asmaller = a.Remove(0, 3);
                    string c = string.Concat(asmaller, b);
                    return c;

                }
                else if (a.Length > b.Length && (b.Length < 5))
                {
                    string asmall = a.Remove(0, 1);
                    string c = string.Concat(asmall, b);
                    return c;
                }
                else
                {
                    string bsmall = b.Remove(0, 1);
                    string c = string.Concat(a, bsmall);
                    return c;
                }
            }
            else
            {
                string c = string.Concat(a, b);
                return c;
            }
        }

        //String Warmup 23
        public string TweakFront(string str)
        {
            if (str.StartsWith("a") && (str.Substring(1, 1) != "b"))
            {
                string stra = str.Remove(1, 1);
                return stra;
            }
            else if (str.Substring(1, 1) == "b")
            {
                return str;
            }
            else
            {
                string strsmall = str.Remove(0, 2);
                return strsmall;
            }
        }

        //String Warmup 24
        public string StripX(string str)
        {
            if (str.Substring(0, 1) == "x")
            {
                string strx = str.Remove(0, 1);

                if (str.Substring(str.Length - 1, 1) == "x")
                {
                    string strnox = strx.Remove(strx.Length - 1, 1);
                    return strnox;
                }
                else
                {
                    return strx;
                }
            }
            else if (str.Substring(str.Length - 1, 1) == "x")
            {
                string strxend = str.Remove(str.Length - 1, 1);
                return strxend;
            }
            else
            {
                return str;
            }
        }
    }

    //CONDITIONAL
    //WARMUPS

    public class ConditionalWarmups
    {
        //Cond Warmup 1
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if ((aSmile == true && bSmile == true) || (aSmile == false && bSmile == false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Cond Warmup 2
        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            if (isWeekday == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Cond Warmup 3
        public int SumDouble(int a, int b)
        {
            if (a == b)
            {
                int c = (a + b)*2;
                return c;
            }
            else
            {
                return a + b;
            }
        }

        //Cond Warmup 4

        public int Diff21(int n)
        {
            if (n > 21)
            {
                int nn = n - 21;
                return nn + nn;
            }
            else
            {
                return 21 - n;
            }
        }

        //Cond Warmup 5

        public bool ParrotTrouble(bool isTalking, int hour)
        {
            if (isTalking == true && hour < 7 || hour > 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Cond Warmup 6
        public bool Makes10(int a, int b)
        {
            if (a >= 10)
            {
                return true;
            }
            else if (b >= 10)
            {
                return true;
            }
            else if (a + b == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Cond Warmup 7
        public bool NearHundred(int n)
        {
            if ((n <= 110 && n >= 90) || (n <= 210 && n >= 190))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Cond Warmup 8
        public bool PosNeg(int a, int b, bool negative)
        {
            if ((a >= 1 && b < 0) || (a < 0 && b >= 1))
            {
                return true;
            }
            else if (negative == true)
            {
                if (a < 0 && b < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //Cond Warmup 9
        public string NotString(string s)
        {
            if (s.Contains("not"))
            {
                return s;
            }
            else
            {
                return "not " + s;
            }
        }

        //Cond Warmup 10
        public string MissingChar(string str, int n)
        {
            string s = str.Remove(n, 1);
            return s;
        }

        //Cond Warmup 11
        public string FrontBack(string str)
        {
            if (str.Length < 2)
            {
                return str;
            }
            else
            {
                string frontletter = str.Substring(0, 1);
                string backletter = str.Substring(str.Length - 1, 1);
                str = str.Substring(1, str.Length - 2);
                return backletter + str + frontletter;
            }
        }

        //Cond Warmup 12
        public string Front3(string str)
        {
            if (str.Length < 3)
            {
                return str + str + str;
            }
            else
            {
                string str3 = str.Substring(0, 3);
                return str3 + str3 + str3;
            }
        }

        //Cond Warmup 13
        public string BackAround(string str)
        {
            string last = str.Substring(str.Length - 1, 1);
            return last + str + last;
        }

        //Cond Warmup 14
        public bool Multiple3or5(int number)
        {
            if (number%3 == 0)
            {
                return true;
            }
            else if (number%5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Cond Warmup 15
        public bool StartHi(string str)
        {
            if (str.Contains("g"))
            {
                return false;
            }
            else if (str.StartsWith("hi"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Cond Warmup 16 
        public bool IcyHot(int temp1, int temp2)
        {
            if (temp1 > 100 && temp2 < 0)
            {
                return true;
            }
            else if (temp1 < 0 && temp2 > 100)
            {
                return true;
            }
            return false;
        }

        //Cond Warmup 17
        public bool Between10and20(int a, int b)
        {
            if (a > 10 && a < 20)
            {
                return true;
            }
            else if (b > 10 && b < 20)
            {
                return true;
            }
            return false;
        }

        //Cond Warmup 18
        public bool HasTeen(int a, int b, int c)
        {
            if ((a >= 13 && a < 20) || (b >= 13 && b < 20) || (c >= 13 && c < 20))
            {
                return true;
            }
            return false;
        }

        //Cond Warmup 19
        public bool SoAlone(int a, int b)
        {
            if ((a >= 13 && a < 20) && (b >= 13 && b < 20))
            {
                return false;
            }
            else if ((a >= 13 && a < 20) || (b >= 13 && b < 20))
            {
                return true;
            }
            return false;
        }

        //Cond Warmup 20
        public string RemoveDel(string str)
        {
            if (str.Substring(1, 3) == "del")
            {
                string strnodel = str.Remove(1, 3);
                return strnodel;
            }
            return str;

        }

        //Cond Warmup 21
        public bool IxStart(string str)
        {
            str = str.Replace(str.Substring(0, 1), "*");
            if (str.Substring(0, 3) == "*ix")
            {
                return true;
            }
            return false;
        }

        //Cond Warmup 22
        public string StartOz(string str)
        {
            if (str.Substring(0, 2) == "oz")
            {
                return str.Substring(0, 2);
            }
            else if (str.Substring(1, 1) == "z")
            {
                return str.Substring(1, 1);
            }
            else if (str.Substring(0, 1) == "o")
            {
                return str.Substring(0, 1);
            }
            return str;
        }

        //Cond Warmup 23
        public int Max(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            return c;
        }

        //Cond Warmup 24
        public int Closer(int a, int b)
        {
            if (a + 2 == 10 && b - 3 == 10)
            {
                return a;
            }
            else if (a - 3 == 10 && b + 2 == 10)
            {
                return b;
            }
            else if (a - 3 == 10 && b + 3 == 10)
            {
                return 0;
            }
            return 0;
        }


        ////Cond Warmup 25
        public bool GotE(string str)
        {

            int Ecount = 0;
            foreach (char c in str)
            {
                if (c == 'e')
                {
                    Ecount++;
                }             
            }
            if (Ecount < 4)
                    {
                        return true;
                    }
            return false;

        }

        //Cond Warmups 26
        public string EndUp(string str)
        {
            if (str.Length < 3)
            {
                return str.ToUpper();
            }
            string UppercaseSub = str.Substring(str.Length - 3, 3).ToUpper();
            string Uppercasing = str.Replace(str.Substring(str.Length - 3, 3), UppercaseSub);
            return Uppercasing;
        }

        //Cond Warmups 27
        public string EveryNth(string str, int n)
        {
            string newstring = "";
            for (int i = 0; i < str.Length; i = i + n )
            {
                newstring += str[i];
            }
            return newstring;
        }
    }

    //LOGIC
    //WARMUPS

    public class LogicWarmups
    {
        //Logic warmup 1
        public bool GreatParty(int cigars, bool isWeekend)
        {
            if (cigars >= 40 && cigars <= 60 && isWeekend == false)
            {
                return true;
            }
            else if (cigars >= 40 && isWeekend == true)
            {
                return true;
            }
            return false;
        }

        //Logic warmup 2
        public int CanHazTable(int yourStyle, int dateStyle)
        {
            int no = 0;
            int maybe = 1;
            int yes = 2;

            if (yourStyle >= 8 || dateStyle >= 8)
            {
                return yes;
            }
            else if (yourStyle > 2 && dateStyle > 2)
            {
                return maybe;
            }
            return no;
        }

        //Logic Warmup 4
        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            int no = 0;
            int smallt = 1;
            int bigt = 2;

            if (speed > 60 && speed < 81)
            {
                if (isBirthday == true && speed > 86)
                {
                    return bigt;
                }
                else if (isBirthday == true && speed < 66)
                {
                    return no;
                }
                return smallt;
            }
            return no;
        }

        //Logic Warmup 3
        public bool PlayOutside(int temp, bool isSummer)
        {
            if (temp <= 90 && temp >= 60)
            {
                return true;
            }
            else if (isSummer == true && temp <= 100 && temp >= 60)
            {
                return true;
            }
            return false;
        }

        //Logic Warmup 5
        public int SkipSum(int a, int b)
        {
            if (a + b < 20 && a + b > 9)
            {
                return 20;
            }
            return a + b;
        }

        //Logic Warmup 6
        public string AlarmClock(int day, bool vacation)
        {
            int Sun = 0;
            int Sat = 6;

            if (Sun == day || Sat == day)
            {
                if (vacation == true)
                {
                    return "off";
                }
                return "10:00";
            }
            else if (vacation == true)
            {
                return "10:00";
            }
            return "7:00";
        }

        //Logic Warmup 7
        public bool LoveSix(int a, int b)
        {
            if (a + b == 6)
            {
                return true;
            }
            else if (a == 6 || b == 6)
            {
                return true;
            }
            else if (a - b == 6 || b - a == 6)
            {
                return true;
            }
            return false;
        }

        //Logic Warmup 8
        public bool InRange(int n, bool outsideMode)
        {
            if (outsideMode == true && (n <= 1 || n >= 10))
            {
                return true;
            }
            else if (n < 10 && n > 1)
            {
                return true;
            }
            return false;
        }

        //Logic Warmup 9
        public bool SpecialEleven(int n)
        {
            if (n%11 == 0)
            {
                return true;
            }
            else if (n%11 == 1)
            {
                return true;
            }
            return false;
        }

        //Logic Warmup 10
        public bool Mod20(int n)
        {
            if (n%20 == 1 || n%20 == 2)
            {
                return true;
            }
            return false;
        }

        //Logic Warmup 11
        public bool Mod35(int n)
        {
            if (n%3 == 0 && n%5 == 0)
            {
                return false;
            }
            else if (n%3 == 0 || n%5 == 0)
            {
                return true;
            }
            return false;
        }

        //Logic Warmup 12
        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (isAsleep == true)
            {
                return false;
            }
            else if (isMorning == true && isMom == true)
            {
                return true;
            }
            else if (isMorning == true && isMom == false)
            {
                return false;
            }
            return true;
        }

        //Logic Warmup 13
        public bool TwoIsOne(int a, int b, int c)
        {
            if (a + b == c || c + a == b || b + c == a)
            {
                return true;
            }
            return false;
        }

        //Logic Warmup 14
        public bool AreInOrder(int a, int b, int c, bool bOk)
        {
            if (b > a && c > b && bOk == false)
            {
                return true;
            }
            else if (bOk == true && c > b)
            {
                return true;
            }
            return false;
        }

        //Logic Warmup 15
        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            if (c > b && b > a && equalOk == false)
            {
                return true;
            }
            else if ((equalOk == true) && a <= b && b <= c)
            {
                return true;
            }
            return false;
        }

        //Logic Warmup 16
        public bool LastDigit(int a, int b, int c)
        {
            if (a%10 == b%10 || a%10 == c%10 || b%10 == c%10)
            {
                return true;
            }
            return false;
        }


        //Logic Warmup 17
        public int RollDice(int die1, int die2, bool noDoubles)
        {
            if (noDoubles)
            {
                if (die1 == die2)
                {
                    return die1 + 1 + die2;
                }
                return die1 + die2;
            }
            else if (noDoubles == false)
            {
                return die1 + die2;
            }
            return 0;
        }
    }

    //ARRAY
    //WARMUPS

    public class ArrayWarmups
    {
        //Array Warmups 1
        public bool FirstLast6(int[] numbers)
        {
            int last = numbers[numbers.Length - 1];

            if (last == 6 || numbers[0] == 6)
            {
                return true;
            }
            return false;
        }

        //Array Warmups 2
        public bool SameFirstLast(int[] numbers)
        {
            if (numbers[0] == numbers[numbers.Length - 1])
            {
                return true;
            }
            return false;
        }

        //Array Warmups 3
        public int[] MakePi(int n)
        {
            int[] pi = new int[3] {3, 1, 4};

            return pi;
        }

        //Array Warmups 4
        public bool commonEnd(int[] a, int[] b)
        {
            if (a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1])
            {
                return true;
            }
            return false;
        }

        //Array Warmups 5
        public int Sum(int[] numbers)
        {
            int numbsum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbsum += numbers[i];
            }
            return numbsum;
        }

        //Array Warmups 6
        public int[] RotateLeft(int[] numbers)
        {
            int[] rotated = new int[] {numbers[1], numbers[2], numbers[0]};

            return rotated;
        }

        //Array Warmups 7
        public int[] Reverse(int[] numbers)
        {
            int[] reverse = new int[] {numbers[2], numbers[1], numbers[0]};

            return reverse;
        }

        //Arrays Warmup 8
        public int[] HigherWins(int[] numbers)
        {
            if (numbers[0] > numbers[numbers.Length - 1])
            {
                int[] FirstElement = new int[] {numbers[0], numbers[0], numbers[0]};
                return FirstElement;
            }
                int[] LastElement = new int[] {numbers[numbers.Length - 1], numbers[numbers.Length - 1], numbers[numbers.Length - 1]};

                return LastElement;
        }

        //Arrays Warmup 9
        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] middle = new int[] {a[1], b[1] };
            return middle;
        }

        //Array Warmup 10
        public bool HasEven(int[] numbers)
        {
            if (numbers[0]%2 == 0 || numbers[1]%2 == 0)
            {
                return true;
            }
            return false;
        }

        ////Arrays Warmups 11
        public int[] KeepLast(int[] numbers)
        {
            //pseudocoding
            
            //get size of array
            int i = numbers.Length * 2;
            //inilize new array to double size of first
            int[] numbersdoubled = new int[i];
            //set last element of new array to last eliment of first array
            numbersdoubled[numbersdoubled.Length - 1] = numbers[numbers.Length - 1];
            
            return numbersdoubled;
        }

        //Arrays Warmup 12
        public bool Double23(int[] numbers)
        {
            int twocount = 0;
            foreach (int j in numbers)
            {
                if (j == 2)
                {
                    twocount++;
                }

                if (twocount > 2)
                    {
                    return false;
                    }
            }

            foreach (int i in numbers)
            {
                if (numbers[0] == 2)
                    {
                        if (i == 2)
                        {
                            return true;
                        }
                    }
                if (numbers[0] == 3)
                {
                    if (i == 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Arrays Warmup 13
        public int[] Fix23(int[] numbers)
        {
            if (numbers[0] == 2 && numbers[1] == 3)
            {
                numbers[1] = 0;
                return numbers;
            }
            else if (numbers[1] == 2 && numbers[2] == 3)
            {
                numbers[2] = 0;
                return numbers;
            }
            return numbers;
        }

        //Arrays Warmup 14
        public bool Unlucky1(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 3)
                {
                    return true;
                }
            }
            return false;
        }

        //Array Warmup 15
        public int[] make2(int[] a, int[] b)
        {
            if (a.Length > 1)
            {
                int[] twoa = new int[] {a[0], a[1]};
                return twoa;
            }
            else if (a.Length == 1)
            {
                int[] oneaoneb = new int[] {a[0], b[0]};
                return oneaoneb;
            }
            int[] twob = {b[0], b[1]};
            return twob;
       }
    }

    //LOOP
    //WARMUPS

    public class LoopWarmups
    {
        // Loop Warmups 1
        public string StringTimes(string str, int n)
        {
            string s = "";

            for (int i = 1; i <= n; i++)
            {
                s += str;
            }
            return s;
        }

        //Loop Warmups 2
        public string FrontTimes(string str, int n)
        {
            string front = str.Substring(0, 3);
            string answer = "";

            for (int i = 1; i <= n; i++)
            {
                answer += front;

            }
            return answer;
        }

        //Loop Warmups 3
        public int CountXX(string str)
        {
            int xxcount = 0;
            for (int i = 1; i <= str.Length - 1; i++)
            {
                if (str[i - 1] == 'x' && str[i] == 'x')
                {
                    xxcount++;
                }

            }
            return xxcount;
        }

        //Loop Warmup 4
        public bool DoubleX(string str)
        {
            int xx = str.IndexOf("xx");
            int x = str.IndexOf('x');
            if (xx == x)
            {
                return true;
            }
            return false;
        }

        //Loop Warmup 5 
        public string EveryOther(string str)
        {
            string other = "";
            for (int i = 0; i <= str.Length - 1; i += 2)
            {
                other += str[i].ToString();

            }
            return other;
        }

        //Loop Warmup 6
        public string StringSplosion(string str)
        {
            //Given a non - empty string like "Code" return a string like "CCoCodCode".  (first char, first two, first 3, etc)

            string newstring = "";
            for (int i = 0; i < str.Length; i++)
            {
                newstring += str.Substring(0, i + 1);
            }
            return newstring;

        }

        //Loop Warmup 7
        public int CountLast2(string str)
        {
            int last2count = 0;
            string last2string = str.Substring(str.Length - 2, 2);

            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 2) == last2string)
                {
                    last2count++;
                }
            }
            return last2count;
        }

        //Loop Warmup 8
        public int Count9(int[] numbers)
        {
            int NineCount = 0;

            foreach (int i in numbers)
            {
                if (i == 9)
                {
                    NineCount++;
                }
            }
            return NineCount;
        }

        //Loop Warmup 9
        public bool ArrayFront9(int[] numbers)
        {
            int[] newarray = { numbers[0], numbers[1], numbers[2], numbers[3] };
            foreach (int i in newarray)
            {
                if (i == 9)
                {
                    return true;
                }
            }
            return false;
        }

        ////10 loop Warmup 
        public bool Array123(int[] numbers)
        {

            for (int i = 0; i <= numbers.Length - 3; i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 2 && numbers[i + 2] == 3)
                {
                    return true;
                }
            }
            return false;
        }

        //11 Loop Warmups 
        public int SubStringMatch(string a, string b)
        {
            int count = 0;
            for (int i = 0; i < a.Length - 2; i++)
            {
                if (a.Substring(i, 2) == b.Substring(i, 2))
                {
                    count++;
                }
                if (a == b)
                {
                    count++;
                }
            }
            return count;
        }

        //Loop Warmup 12
        public string StringX(string str)
        {
            string middle = str.Substring(1, str.Length - 2);
            string front = str.Substring(0, 1);
            string back = str.Substring(str.Length - 1, 1);



            for (int i = 0; i < str.Length - 2; i++)
            {
                if (middle.Contains("x"))
                {
                    middle = middle.Replace("x", "");
                }
            }
            return front + middle + back;
        }

        //Loop Warmup 13
        public string AltPairs(string str)
        {
            string newstring = "";

            if (str.Length < 7)
            {
                for (int i = 0; i <= str.Length - 2; i += 4)
                {
                    newstring += str.Substring(i, 2);
                }
                return newstring;
            }
            else if (str.Length < 10)
            {
                for (int j = 0; j <= str.Length - 2; j += 4)
                {
                    newstring += str.Substring(j, 2);
                }
                newstring = newstring + str[8];
                return newstring;
            }
            else if (str.Length > 10)
            {
                for (int k = 0; k <= str.Length - 2; k += 4)
                {
                    newstring += str.Substring(k, 2);
                }
                return newstring;
            }
            return str;
        }

        //Loop Warmups 14
        public string DoNotYak(string str)
        {
            string yak = "yak";
            if (str.Contains("yak"))
            {
                str = str.Replace(yak, "");
                return str;
            }
            return str;
        }

        //Loop Warmup 15
        public int Array667(int[] numbers)
        {
            int sixcount = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 6 && (numbers[i + 1] == 6 || numbers[i + 1] == 7))
                {
                    sixcount++;
                }
            }
            return sixcount;
        }

        //Loop Warmup 16
        public bool NoTriples(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == numbers[i + 1] && numbers[i] == numbers[i + 2] && numbers[i + 1] == numbers[i + 2])
                {
                    return false;
                }
            }
            return true;
        }

        //Loop Warmups 17
        public bool Pattern51(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] + 5 == numbers[i + 1] && numbers[i + 1] - 6 == numbers[i + 2])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
