package conversor;
import java.util.Scanner;

public class Conversor {
	public static float toCelsius (float graus) {
		return (graus - 32) * 5 / 9;
		
	}
	public static float toFahrenheit (float graus) {
		return (graus * 9 / 5) + 32;
	}
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		float temperatura;
		int unidade;
		System.out.println("Informe a temperatura:");
		temperatura = sc.nextFloat();
		System.out.println("Qual a unidade? 1- Celsius 2-Fahrenheit");
		unidade = sc.nextInt();
		
		if (unidade == 1) {
			System.out.println(Conversor.toFahrenheit(temperatura) + "F");
			
		}else
		if (unidade == 2) {
			System.out.println(Conversor.toCelsius(temperatura) + "C");
			
		}
		else {
			System.out.println("Conversão não disponível");
		}
	}
}
