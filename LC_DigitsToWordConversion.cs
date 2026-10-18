namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OntToNineHNN(549);//Five Hundread Fourty Nine
            OntToNineHNN(342);//Three Hundread Fourty Two
            OntToNineHNN(17);//Seventeen
            OntToNineHNN(100);
            OntToNineHNN(101);
            OntToNineHNN(999);
            OntToNineHNN(0);
        }

        static void OntToNineHNN(int num)
        {
            //string str = "Onkar";
            //str += " Thombre";

            //Console.WriteLine(str);

            string ans = "";

            int temp = num;
            int count = 0;
            while (temp != 0)
            {
                count += 1;
                temp /= 10;
            }
            if(temp == 0)
            {
                Console.WriteLine($"{num} is :- Zero");
            }

            if (count == 3) // for hundread level
            {
                CountThree(ref ans, num);
            }

            if (count == 2) // for ten level
            {
                CountTwo(ref ans, num);
            }

            if(count == 1)
            {
                CountOne(ref ans , num);
            }
            Console.WriteLine($"{num} is :- {ans}");
        }
        private static void CountOne(ref string ans, int unitdigit)
        {
            if (unitdigit == 0)
            {
                ans += " .";
            }
            else if (unitdigit == 1)
            {
                ans += " One";
            }
            else if (unitdigit == 2)
            {
                ans += " Two";
            }
            else if (unitdigit == 3)
            {
                ans += " Three";
            }
            else if (unitdigit == 4)
            {
                ans += " Four";
            }
            else if (unitdigit == 5)
            {
                ans += " Five";
            }
            else if (unitdigit == 6)
            {
                ans += " Six";
            }
            else if (unitdigit == 7)
            {
                ans += " Seven";
            }
            else if (unitdigit == 8)
            {
                ans += " Eight";
            }
            else if (unitdigit == 9)
            {
                ans += " Nine";
            }
        }
        private static void CountTwo(ref string ans, int num)
        {
            if (num == 00)
            {
                ans += " .. ";
            }
            else if (num == 10)
            {
                ans += " Ten";
            }
            else if (num == 11)
            {
                ans += " Eleven";
            }
            else if (num == 12)
            {
                ans += " Twelve";
            }
            else if (num == 13)
            {
                ans += " Thirteen";
            }
            else if (num == 14)
            {
                ans += " Fourteen";
            }
            else if (num == 15)
            {
                ans += " Fifteen";
            }
            else if (num == 16)
            {
                ans += " Sixteen";
            }
            else if (num == 17)
            {
                ans += " Seventeen";
            }
            else if (num == 18)
            {
                ans += " Eighteen";
            }
            else if (num == 19)
            {
                ans += " Ninteen";
            }
            else
            {
                int tens_digit = num / 10;
                int unitdigit = num % 10;
                if (tens_digit == 0)
                {
                    ans += " . ";
                    CountOne(ref ans, unitdigit);
                }
                else if (tens_digit == 2)
                {
                    ans += " Twenty";
                    CountOne(ref ans, unitdigit);
                }
                else if (tens_digit == 3)
                {
                    ans += " Thirty";
                    CountOne(ref ans, unitdigit);
                }
                else if (tens_digit == 4)
                {
                    ans += " Fourty";
                    CountOne(ref ans, unitdigit);
                }
                else if (tens_digit == 5)
                {
                    ans += " Fifty";
                    CountOne(ref ans, unitdigit);
                }
                else if (tens_digit == 6)
                {
                    ans += " Sixty";
                    CountOne(ref ans, unitdigit);
                }
                else if (tens_digit == 7)
                {
                    ans += " Seventy";
                    CountOne(ref ans, unitdigit);
                }
                else if (tens_digit == 8)
                {
                    ans += " Eighty";
                    CountOne(ref ans, unitdigit);
                }
                else if (tens_digit == 9)
                {
                    ans += " Nintey";
                    CountOne(ref ans, unitdigit);
                }
            }


        }
        static void CountThree(ref string ans, int num)
        {
            int hundread_digit = num / 100;
            int tendigits = num % 100;
            string hund = "hundread";
            if (hundread_digit == 1)
            {
                ans += "One Hundread";
                CountTwo(ref ans, tendigits);
            }
            else if (hundread_digit == 2)
            {
                ans += "Two Hundread";
                CountTwo(ref ans, tendigits);
            }
            else if (hundread_digit == 3)
            {
                ans += "Three Hundread";
                CountTwo(ref ans, tendigits);
            }
            else if (hundread_digit == 4)
            {
                ans += "Four Hundread";
                CountTwo(ref ans, tendigits);
            }
            else if (hundread_digit == 5)
            {
                ans += "Five Hundread";
                CountTwo(ref ans, tendigits);
            }
            else if (hundread_digit == 6)
            {
                ans += "Six Hundread";
                CountTwo(ref ans, tendigits);
            }
            else if (hundread_digit == 7)
            {
                ans += "Seven Hundread";
                CountTwo(ref ans, tendigits);
            }
            else if (hundread_digit == 8)
            {
                ans += "Eight Hundread";
                CountTwo(ref ans, tendigits);
            }
            else if (hundread_digit == 9)
            {
                ans += "Nine Hundread";
                CountTwo(ref ans, tendigits);
            }
        }
    }
}
