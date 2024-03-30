using System.Reflection.Metadata;
using static System.Console;

namespace _5
{
    internal class Program
    {
        //task 1
        /*
        static public float Plus(float first, float second)
        {
            return first + second;
        }
        static public float Minus(float first, float second)
        {
            return first - second;
        }
        static public float Multiply(float first, float second)
        {
            return first * second;
        }
        static public float Divide(float first, float second)
        {
            if (second == 0) throw new DivideByZeroException("Trying to divide by zero!");
            return first / second;
        }
        public static int BinaryToDecimal(string binaryText)
        {
            if (string.IsNullOrEmpty(binaryText))
            {
                throw new ArgumentException("Invalid argument: Input cannot be empty");
            }

            for (int i = 0; i < binaryText.Length; i++)
            {
                if (binaryText[i] != '1' && binaryText[i] != '0')
                {
                    throw new ArgumentException("Invalid argument: Input must be a binary string");
                }
            }

            int decimalValue = Convert.ToInt32(binaryText, 2);
            return decimalValue;
        }

        static private void Create2Variables(out float first, out float second)
        {
            first = second = 0;

            Write("Enter first value: ");
            if (!float.TryParse(ReadLine(), out first))
            {
                throw new Exception("TryParse error!");
            }

            Write("Enter second value: ");
            if (!float.TryParse(ReadLine(), out second))
            {
                throw new Exception("TryParse error!");
            }
        }
        */

        //task 2
        /*
        enum Numbers
        {
            zero, one, two, three, four, five, six, seven, eight, nine
        }

        static public int TranslateToNumber(string text)
        {
            char[] tokens = text.ToCharArray();
            for (int i = 0; i < tokens.Length; i++)
            {
                if (!char.IsLetter(tokens[i]))
                {
                    throw new ArgumentException("Invalid argument!");
                }
                if (char.IsUpper(tokens[i]))
                {
                    tokens[i] = char.ToLower(tokens[i]);
                }
            }
            string new_text = new string(tokens);

            if (!Enum.IsDefined(typeof(Numbers), new_text))
            {
                throw new ArgumentException("Invalid argument!");
            }
            return (int)Enum.Parse(typeof(Numbers), new_text);
        }
        */

        //task 4
        static public bool LogicExpression(string expr)
        {
            if (expr == string.Empty) throw new ArgumentException("Invalid argument!");

            string[] tokens = expr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length != 3)
            {
                throw new ArgumentException("Invalid argument!");
            }
            string[] symbols = { "<", ">", "<=", ">=", "==", "!=" };
            for (int i = 0; i < tokens.Length; i++)
            {
                bool isSymbol = false;
                for (int j = 0; j < symbols.Length; j++)
                {
                    if (tokens[i] == symbols[j]) isSymbol = true;
                }
                if (!isSymbol)
                {
                    int num;
                    if (!int.TryParse(tokens[i], out num))
                    {
                        throw new ArgumentException("Invalid argument!");
                    }
                }
            }

            string symbol = tokens[1];
            int first = int.Parse(tokens[0]);
            int second = int.Parse(tokens[2]);
            switch (symbol)
            {
                case ">": return first > second;
                case "<": return first < second;
                case ">=": return first >= second;
                case "<=": return first <= second;
                case "==": return first == second;
                case "!=": return first != second;
                default: throw new Exception("Error!");
            }
        }

        static void Main(string[] args)
        {
            //task 1
            /*
                int choice = -1;
                while (choice != 0)
                {
                    try
                    {
                        Write("1 - Plus\n2 - Minus\n3 - Multiply\n4 - Divide\n5 - From binary to decimal\n0 - Exit\n: ");
                        if (!int.TryParse(ReadLine(), out choice))
                        {
                            throw new Exception("TryParse error!");
                        }
                        if (choice != 1 && choice != 2 && choice != 3 && choice != 4 && choice != 5 && choice != 0)
                        {
                            throw new Exception("Invalid choice!");
                        }
                        WriteLine();

                        float rez = 0;
                        float first, second;
                        bool isChanged = false;
                        switch (choice)
                        {
                            case 1:
                                Create2Variables(out first, out second);
                                rez = Plus(first, second);
                                isChanged = true;
                                break;
                            case 2:
                                Create2Variables(out first, out second);
                                rez = Minus(first, second);
                                isChanged = true;
                                break;
                            case 3:
                                Create2Variables(out first, out second);
                                rez = Multiply(first, second);
                                isChanged = true;
                                break;
                            case 4:
                                Create2Variables(out first, out second);
                                rez = Divide(first, second);
                                isChanged = true;
                                break;
                            case 5:
                                Write("Enter a binary number(example: 10110): ");
                                rez = BinaryToDecimal(ReadLine());
                                isChanged = true;
                                break;
                        }
                        if (isChanged) WriteLine($"Result: {rez}");
                        ReadKey();
                        Clear();
                    }
                    catch(ArgumentException er)
                    {
                        WriteLine(er.Message);
                    }
                    catch(DivideByZeroException er)
                    {
                        WriteLine(er.Message);
                    }
                    catch(Exception er)
                    {
                        WriteLine(er.Message);
                    }
                }
            */

            //task 2
            /*
            try
            {
                string text;
                Write("Enter a text: ");
                text = ReadLine();
                if (text == string.Empty) throw new Exception("Invalid input!");

                int rez = TranslateToNumber(text);
                WriteLine(rez);
            }
            catch(ArgumentException e)
            {
                WriteLine(e.Message);
            }
            catch(Exception e)
            {
                WriteLine(e.Message);
            }
            */

            //task 3
            /*
            try
            {
                InternationalPassport myPass = new InternationalPassport();
                myPass.Show();
                ReadKey();
                myPass.Input();
                myPass.Show();

                WriteLine();
                ReadKey();
                Clear();

                InternationalPassport myPass1 = new InternationalPassport("11375859358373", "HIV", 2023, 04, 12);
                myPass1.Show();
            }
            catch (ArgumentException ex)
            {
                WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            */

            //task 4
            /*
            string expr;
            Write("Enter a text(format: 2 > 3): ");
            expr = ReadLine();

            try
            {
                if (LogicExpression(expr)) WriteLine("TRUE");
                else WriteLine("FALSE");
            }
            catch (ArgumentException ex)
            {
                WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            */

            WriteLine();
            ReadKey();
        }
    }
}
