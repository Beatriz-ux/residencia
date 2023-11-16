package calculadora;

import java.util.Scanner;

public class Calculadora {
	public static double adicao(double x, double y) {
		return x+y;
	}
	public static double subtracao(double x, double y) {
		return x-y;
	}
	public static double multiplicacao(double x, double y) {
		return x*y;
	}
	public static double divisao(double x, double y) {
		return x/y;
	}
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		double num1, num2;
		int operacao;
		System.out.println("Informe o primeiro numero:");
		num1 = sc.nextDouble();
		System.out.println("Informe o segundo numero:");
		num2 = sc.nextDouble();
		System.out.println("Escolha uma operação:");
		System.out.println("1 - Soma");
		System.out.println("2 - Subtracao");
		System.out.println("3 - Multiplicação:");
		System.out.println("4 - Divisão");
		operacao = sc.nextInt();
		
		switch (operacao) {
		case 1:
			System.out.println(num1+ " + " + num2 + " = " + Calculadora.adicao(num1, num2));
			break;
		case 2:
			System.out.println(num1+ " - " + num2 + " = " + Calculadora.subtracao(num1, num2));
			break;
		case 3:
			System.out.println(num1+ " * " + num2 + " = " + Calculadora.multiplicacao(num1, num2));
			break;
		case 4:
			if(num2 !=0)
				System.out.println(num1+ " / " + num2 + " = " + Calculadora.divisao(num1, num2));
			System.out.println("Divisão não pode ser feita.");
			break;
		default:
			System.out.println("Operação inválida.");
			break;
		}
	}

}
