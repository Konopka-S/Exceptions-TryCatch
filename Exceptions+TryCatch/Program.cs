CalculatorApp();

void CalculatorApp()
{
    try
    {
        Console.Write("Enter first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter an operator (+, -, *, /): ");

        char operation = Convert.ToChar(Console.ReadLine());
        int result = 0;
        

        switch (operation)
        {
            case '+':
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            case '*':
                result = firstNumber * secondNumber;
                break;
            case '/':
                result = firstNumber / secondNumber;
                break;
            default:
                Console.WriteLine("Invalid operator.");
                return;
        }
        Console.WriteLine($"Result: {result}");
    }
    catch(FormatException)
    {
        Console.WriteLine("Input was not in a correct format. Please enter valid numbers.");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero. Please enter a non-zero second number.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An unexpected error occurred: {ex.Message}");
    }
}