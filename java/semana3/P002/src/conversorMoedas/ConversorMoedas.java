package conversorMoedas;

import java.util.Scanner;

public class ConversorMoedas {
	public static float converte(float taxa,float quantidade) {
		
		return taxa*quantidade;
	}
	public static void main(String[] args) {
		String moeda1, moeda2;
		Scanner sc = new Scanner(System.in);
		System.out.println("Gostaria de converter de? ex: 'real'");
		moeda1= sc.next();
		
		double x ,y;
		x=2;
		do {
			y=x;
			x=x/2;
			
		}while(x>0);
		
		System.out.println("float:"+y);
		System.out.println("Double:"+y);
		
	}
}
