using System;
using System.Globalization;
using System.Windows.Forms;

public class Operations
{
	private char operation;
	private double nextNumber;
	public Operations() {
		operation = ' ';
		nextNumber = 0.0;
	}
	public double Repeater(Queue operators, Queue numbers) {
		double majorResult = Convert.ToDouble(numbers.Dequeue());
        while(!numbers.isEmpty()) {
			operation = Convert.ToChar(operators.Dequeue());
			nextNumber = Convert.ToDouble(numbers.Dequeue());
			majorResult = Calculator(operation, majorResult, nextNumber);
        }
		return majorResult;
    }
	private double Calculator(char type, double result, double number) {
        switch(type) {
			case '+': result = Plus(result, number);
				break;
			case '-': result = Minus(result, number);
				break;
			case 'x': result = Times(result, number);
				break;
			case '/': result = Divide(result, number);
				break;
		}
		return result;
    }
	private double Plus(double numberA, double numberB) {
		return numberA + numberB;
    }
	private double Minus(double numberA, double numberB) {
		return numberA - numberB;
    }
	private double Times(double numberA, double numberB) {
		return numberA * numberB;
    }
	private double Divide(double numberA, double numberB) {
		if(numberA == 0 || numberB == 0) {
			MessageBox.Show("Não é possível dividir por zero!", "Aviso");
			return 0;
		}
		return numberA / numberB;
    }
}
