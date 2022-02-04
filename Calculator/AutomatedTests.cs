using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator
{
    class AutomatedTests
    {
        Queue operations;
        Queue numbers;
        Operations calculator;

        public AutomatedTests()
        {
            operations = new Queue();
            numbers = new Queue();
            calculator = new Operations();
        }
        private void StackNumber(int numberParam)
        {
            Cell number = new Cell(null, 0.0);
            number.SetValue(numberParam);
            numbers.Enqueue(number);
        }
        private void StackOperator(char operationParam)
        {
            Cell operation = new Cell(null, 0.0);
            operation.SetValue(operationParam);
            operations.Enqueue(operation);
        }
        public string CalculateTest1(string resultadoEsperado)
        {
            StackNumber(123);
            StackOperator('+');
            StackNumber(456);
            StackOperator('+');
            StackNumber(789);
            StackOperator('+');
            StackNumber(987);
            StackOperator('+');
            StackNumber(654);
            StackOperator('+');
            StackNumber(321);
            StackOperator('+');
            StackNumber(123);
            StackOperator('+');
            StackNumber(456);
            StackOperator('+');
            StackNumber(789);
            StackOperator('+');
            StackNumber(951);

            string verifica = calculator.Repeater(operations, numbers).ToString();

            if (verifica.Equals(resultadoEsperado))
                return "A soma de 123 + 456 + 789 + 987 + 654 + 321 + 123 + 456 + 789 + 951 = " + resultadoEsperado + "\n" + "Resultado obtido = " + verifica;
            else
                return "A soma de 123 + 456 + 789 + 987 + 654 + 321 + 123 + 456 + 789 + 951 = " + resultadoEsperado + "\n" + "Resultado obtido = " + verifica;
        }

        public string CalculateTest2(string resultadoEsperado)
        {

            StackNumber(125);
            StackOperator('*');
            StackNumber(5);
            StackOperator('-');
            StackNumber(147);
            StackOperator('/');
            StackNumber(5);
            StackOperator('+');
            StackNumber(1);

            string verifica = calculator.Repeater(operations, numbers).ToString();
            if (verifica.Equals(resultadoEsperado))
                return "A soma de 125 * 5 - 147 / 5 + 1 = " + resultadoEsperado + "\n" + "Resultado obtido = " + verifica;
            else
                return "A soma de 125 * 5 - 147 / 5 + 1 = " + resultadoEsperado + "\n" + "Resultado obtido = " + verifica;
        }
    }
}
