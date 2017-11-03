using System;
using System.IO;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace CodeFights
{
    public partial class Template
    {
        static bool sudoku(int[][] grid)
        {
            var checkLine = grid.All(x => x.Distinct().Count() == 9);
            var checkCol = Enumerable.Range(0, grid.Length).Select(x => Enumerable.Range(0, grid.Length).Select(y => grid[y][x])).Any(x => x.Distinct().Count() == 9);
            var checkMatrix = Enumerable.Range(0, grid.Length / 3).SelectMany(x => Enumerable.Range(0, grid.Length / 3).Select(y => Enumerable.Range(0, 3).SelectMany(a => Enumerable.Range(0, 3).Select(b => grid[3 * x + a][3 * y + b]))).Select(_ => _.Distinct().Count() == 9)).All(x => x);
            var tmp = Enumerable.Range(0, grid.Length / 3).Select(x => Enumerable.Range(0, grid.Length / 3).Select(y => Enumerable.Range(0, 3).SelectMany(a => Enumerable.Range(0, 3).Select(b => grid[3 * x + a][3 * y + b])).ToArray()).ToArray()).ToArray();
            return checkLine && checkCol & checkMatrix;
        }
        static int[][] spiralNumbers(int n)
        {
            int[][] rlt = Enumerable.Range(0, n).Select(_ => new int[n]).ToArray();
            int cnt = 1;
            int x = 0;
            int y = 0;
            int dx = 0;
            int dy = 1;
            while (cnt <= (n * n))
            {
                Console.WriteLine($"({x},{y})");
                rlt[x][y] = cnt;

                if (dx == 1)
                {
                    if (x == n - 1 || rlt[x + 1][y] != 0)
                    {
                        dx = 0;
                        dy = -1;
                    }
                }
                else if (dx == -1)
                {
                    if (x == 0 || rlt[x - 1][y] != 0)
                    {
                        dx = 0;
                        dy = 1;
                    }
                }
                else if (dy == 1)
                {
                    if (y == n - 1 || rlt[x][y + 1] != 0)
                    {
                        dx = 1;
                        dy = 0;
                    }
                }
                else if (dy == -1)
                {
                    if (y == 0 || rlt[x][y - 1] != 0)
                    {
                        dx = -1;
                        dy = 0;
                    }
                }

                x += dx;
                y += dy;
                cnt++;
            }
            return rlt;
        }


        static string messageFromBinaryCode(string code)
        {
            return new string(Enumerable.Range(0, code.Length / 8).Select(x => (char)(Convert.ToInt32(new string(code.Skip(8 * x).Take(8).ToArray()), 2))).ToArray());
        }

        static string[] fileNaming(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names.Take(i).Contains(names[i]))
                {
                    int cnt = 1;
                    while (names.Take(i).Contains($"{names[i]}({cnt})")) { cnt++; }
                    names[i] = $"{names[i]}({cnt})";
                }
            }
            return names;
        }

        static int digitsProduct(int product)
        {
            var answerDigits = string.Empty;

            if (product == 0) { return 10; }
            if (product == 1) { return 1; }

            for (var divisor = 9; divisor > 1; divisor--)
            {
                while (product % divisor == 0)
                {
                    product /= divisor;
                    answerDigits += divisor;
                }
            }

            if (product > 1) { return -1; }

            return Convert.ToInt32(new string(answerDigits.Reverse().ToArray()));
            // int input = product;
            // string rlt = string.Empty;
            // int div = MaxDivides(input);
            // while (div > 1)
            // {
            //     input = (input / div);
            //     rlt += div.ToString();
            //     div = MaxDivides(input);
            // }
            // return rlt.Length == 0 ? -1 : Convert.ToInt32(new string(rlt.Reverse().ToArray()));
        }

        static int MaxDivides(int input)
        {
            if (input == 0) { return 10; }
            if (Enumerable.Range(1, 9).Any(x => input % x == 0))
            {
                return Enumerable.Range(1, 9).Reverse().FirstOrDefault(x => input % x == 0);
            }
            else
            {
                return -1;
            }
        }

        static int differentSquares(int[][] matrix)
        {
            var rlt = Enumerable.Range(0, matrix.Length - 1)
                                .SelectMany(
                                     i => Enumerable.Range(0, matrix[i].Length - 1)
                                                        .Select(
                                                            j =>
                                                                Convert.ToInt32(Enumerable.Range(0, 2)
                                                                                      .Select(k => Enumerable.Range(0, 2)
                                                                                                             .Select(l => matrix[i + k][j + l].ToString())
                                                                                                             .Aggregate((a, b) => a + b)
                                                                                      ).Aggregate((a, b) => a + b)
                                                                          )
                                                        )
                                )
                                .Distinct()
                                .Count()
                                ;
            return rlt;
        }

        static int sumUpNumbers(string inputString)
        {
            return Regex.Matches(inputString, @"\d+").Cast<Match>().Sum(x => int.Parse(x.Value));
        }

        static bool validTime(string time)
        {
            DateTime d;
            return DateTime.TryParseExact(time, "HH:mm", null, DateTimeStyles.None, out d);
        }

        static string longestWord(string text)
        {
            var tmp = Regex.Split(text, @"\W+");
            var max = tmp.Max(x => x.Length);
            return tmp.FirstOrDefault(x => x.Length == max);
        }

        static int deleteDigit(int n)
        {
            string s = n.ToString();
            return Enumerable.Range(0, s.Length).Select(x => int.Parse(s.Remove(x, 1))).Max();
        }

        static int chessKnight(string cell)
        {
            int boundry = 7;
            var tmp = Enumerable.Range(-2, 5).Where(x => x != 0);
            var possible = tmp.SelectMany(x => tmp.Select(y => new { x = x, y = y })).Where(_ => Math.Abs(_.x) != Math.Abs(_.y)).ToArray();
            var pos = new { x = cell[0] - 'a', y = cell[1] - '0' - 1 };

            return possible.Count(
                _ =>
                {
                    int x = pos.x + _.x;
                    int y = pos.y + _.y;
                    return (x >= 0 && x <= boundry) && (y >= 0 && y <= boundry);
                }
            );
        }

        static string lineEncoding(string s)
        {
            StringBuilder sb = new StringBuilder();
            int index = 0;
            char current;
            int count;
            while (index < s.Length)
            {
                current = s[index];
                count = s.Skip(index).TakeWhile(x => x == current).Count();
                sb.Append($"{(count > 1 ? count.ToString() : string.Empty)}{current}");

                index += count;
            }

            return sb.ToString();
        }


        bool isDigit(char symbol)
        {
            return Char.IsDigit(symbol);
        }

        bool isMAC48Address(string inputString)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(inputString, "^[0-9A-F]{2}-[0-9A-F]{2}-[0-9A-F]{2}-[0-9A-F]{2}-[0-9A-F]{2}-[0-9A-F]{2}$");
        }


        static int electionsWinners(int[] votes, int k)
        {
            var max = votes.Max();
            return (k == 0) ? Convert.ToInt32(votes.Count(x => x == max) == 1) : votes.Count(x => x + k > max);
            // return votes.Select((v1, i1) => !votes.Where((v2, i2) => i1 != i2 && v1 + k <= v2).Any()).Where(x => x).Count();
        }

        static string buildPalindrome(string st)
        {
            string reverse = new string(st.Reverse().ToArray());
            int count = reverse.Length;

            while (st.LastIndexOf(reverse.Substring(0, count)) < 0)
            {
                count--;
            }

            return st.Substring(0, st.LastIndexOf(reverse.Substring(0, count))) + reverse;
        }

        static string findEmailDomain(string address)
        {
            return address.Substring(address.LastIndexOf('@') + 1);
        }

        static bool isBeautifulString(string inputString)
        {
            var cnt = Enumerable.Range('a', 'z' - 'a' + 1).Select(x => inputString.Count(y => y == x));
            return cnt.SequenceEqual(cnt.OrderByDescending(x => x));
        }

        static bool bishopAndPawn(string bishop, string pawn)
        {
            var bi = (x: bishop[0] - 'a' + 1, y: bishop[1] - '0');
            var pa = (x: pawn[0] - 'a' + 1, y: pawn[1] - '0');

            return Math.Abs(((bishop[1] - '0') - (pawn[1] - '0') * 1.0) / ((bishop[0] - 'a' + 1) - (pawn[0] - 'a' + 1) * 1.0)) == 1;
        }

        static int digitDegree(int n)
        {
            int cnt = 0;
            string tmp = string.Empty;

            while (n >= 10)
            {
                tmp = n.ToString();
                n = tmp.Sum(x => x - '0');
                cnt++;
            }

            return cnt;
        }

        static string longestDigitsPrefix(string inputString)
        {
            return new string(inputString.TakeWhile(Char.IsDigit).ToArray());
        }

        static int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            if (maxW >= weight1 + weight2)
            {
                return value1 + value2;
            }
            else if (maxW >= weight1 && maxW >= weight2)
            {
                return Math.Max(value1, value2);
            }
            else if (maxW < weight1 && maxW >= weight2)
            {
                return value2;
            }
            else if (maxW < weight2 && maxW >= weight1)
            {
                return value1;
            }
            else
            {
                return 0;
            }
        }
        static int growingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {
            int x = 0;
            int day = 1;

            do
            {
                x += upSpeed;
                if (x >= desiredHeight) { break; }
                day++;
                x -= downSpeed;
            } while (true);

            return day;
        }

        static int arrayMaxConsecutiveSum(int[] inputArray, int k)
        {
            if (k == 1)
            {
                return inputArray.Max();
            }
            else if (k > inputArray.Length)
            {
                return inputArray.Sum();
            }
            else
            {
                int prev = inputArray[0];
                int sum = inputArray.Take(k).Sum();
                int max = inputArray.Take(k).Sum();
                for (int i = k; i < inputArray.Length; i++)
                {
                    sum = sum + inputArray[i] - prev;
                    prev = inputArray[i - k + 1];
                    if (max < sum) { max = sum; }
                }
                return max;
            }
            // return Enumerable.Range(0, inputArray.Length - k + 1).Select(x => x).Max(x => Enumerable.Range(0, k).Select(u => inputArray[u + x]).Sum());
        }
        static int differentSymbolsNaive(string s)
        {
            return s.Distinct().Count();
        }

        static char firstDigit(string inputString)
        {
            return inputString.First(x => Char.IsDigit(x));
        }
        static int seatsInTheater(int nCols, int nRows, int col, int row)
        {
            return ((nCols - col) * (nCols - col)) * ((nRows - row) * (nRows - row));
        }
        static int candies(int n, int m)
        {
            return m - m % n;
        }

        static int largestNumber(int n)
        {
            return Convert.ToInt32(Math.Pow(10, 2)) - 1;
        }

        static int addTwoDigits(int n)
        {
            return n.ToString().Sum(x => Convert.ToInt32(x.ToString()));
        }

        static int[] extractEachKth(int[] inputArray, int k)
        {
            return inputArray.Where((x, i) => i + 1 % k > 0).ToArray();
        }

        static bool stringsRearrangement(string[] r)
        {
            return r.Any(_ => S(r, _));
        }

        static bool S(string[] r, string s)
        {

            return !r.Any() | r.Where((_, i) => _.Where((c, j) => c != s[j]).Count() == 1 && S(r.Where((o, j) => i != j).ToArray(), _)).Any();
        }

        static int absoluteValuesSumMinimization(int[] a)
        {
            return a[a.Length - 1 / 2];
        }

        static int depositProfit(int deposit, int rate, int threshold)
        {
            int year = 0;
            double cnt = deposit;
            double Q = rate / 100.0 + 1;
            while (cnt < threshold)
            {
                cnt = cnt * Q;
                year++;
            }
            return year;
        }

        static int circleOfNumbers(int n, int firstNumber)
        {
            return firstNumber > n ? Math.Abs(n / 2 - firstNumber) : n / 2 + firstNumber;
        }

        static bool palindromeRearranging(string inputString)
        {
            return inputString.GroupBy(x => x).Select(x => x.Count() % 2).Sum() < 2;
        }

        static int arrayChange(int[] inputArray)
        {
            int last = inputArray[0] - 1;
            Console.WriteLine(last);
            return inputArray.Sum(_ => (last = Math.Max(last + 1, _)) - _);
        }
        static bool areSimilar(int[] a, int[] b)
        {
            int diff = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) { diff++; }
            }
            if (diff > 2) { return false; }
            return a.OrderBy(x => x).SequenceEqual(b.OrderBy(x => x));
        }

        static int[] alternatingSums(int[] a)
        {
            return new int[] { a.Where((v, i) => i % 2 == 0).Sum(), a.Where((v, i) => i % 2 == 1).Sum() };
        }



        static string[] addBorder(string[] picture)
        {
            int max = picture.Select(x => x.Length).Max() + 2;
            string[] result = new string[picture.Length + 2];
            result[0] = new string('*', max);
            for (int i = 0; i < picture.Length; i++)
            {
                result[i + 1] = "*" + picture[i] + "*";
            }
            result[result.Length - 1] = new string('*', max);

            return result;
        }

        static string reverseParentheses(string s)
        {
            int left = s.LastIndexOf('(');
            int right = -1;
            string tmp;
            while (s.LastIndexOf('(') >= 0)
            {
                right = s.IndexOf(')', left);

                tmp = new string(s.Substring(left + 1, right - left - 1).Reverse().ToArray());
                s = s.Substring(0, left) + tmp + s.Substring(right + 1, s.Length - right - 1);
                left = s.LastIndexOf('(');
            }
            return s;
        }

        static int commonCharacterCount(string s1, string s2)
        {
            return s1.ToArray()
            .GroupBy(x => x)
            .Select(x => new { c = x.Key, count = x.Count() })
            .Concat(
                s2.ToArray()
                    .GroupBy(x => x)
                    .Select(x => new { c = x.Key, count = x.Count() })
            )
            .GroupBy(x => x.c)
            .Where(x => x.Count() > 1)
            .Select(x => x.Min(y => y.count))
            .First()
            ;
        }
        static int isLucky(int n)
        {
            return int.Parse(n.ToString().Substring(0, n.ToString().Length / 2)) + int.Parse(n.ToString().Substring(n.ToString().Length / 2, n.ToString().Length - n.ToString().Length / 2));
        }

        static int[] sortByHeight(int[] a)
        {
            int[] num = a.Where(x => x != -1).OrderBy(x => x).ToArray();
            int cnt = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == -1) { continue; }

                a[i] = num[cnt++];
            }

            return a;
        }
        static void ChangeReadonly(string Path, bool ReadOnly)
        {
            try
            {
                var dir = new DirectoryInfo(Path);
                foreach (FileInfo each in dir.GetFiles())
                {
                    each.IsReadOnly = ReadOnly;
                }
                foreach (DirectoryInfo each in dir.GetDirectories())
                {
                    Console.WriteLine(each.FullName);
                    Console.WriteLine(each.Attributes);
                    each.Attributes = FileAttributes.Directory;
                    Console.WriteLine(each.Attributes);
                    ChangeReadonly(each.FullName, ReadOnly);
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}