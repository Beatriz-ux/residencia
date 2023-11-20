package funcoes;

import java.util.Scanner;

public class Funcoes {
	public static int somaInt(int x, int y) {
		//questao 1
		return x+y;
	}
	
	public static float mediaPonderada(Float n1,Float p1,Float n2,Float p2,Float n3,Float p3) {
		//questao2
		float media;
		media = n1*p1 + n2*p2+ n3*p3;
		media = media/ (p1+p2+p3);
		return media;
	}
	
	public static String conct(String x, String y) {
		//questao3
		String resultado;
		resultado = x+y;
		return resultado;
	}
	
	public static boolean isPar(int x) {
		//questao4
		if (x%2 == 0)
			return true;
	
		return false;
	}
	
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int num1=6, num2=10;
		Funcoes.somaInt(num1,num2);
		
		float n1,n2,n3,p1,p2,p3;
		System.out.println("Informe a nota 1:");
		n1 = sc.nextFloat();
		System.out.println("Informe o peso 1:");
		p1 = sc.nextFloat();
		System.out.println("Informe a nota 2:");
		n2 = sc.nextFloat();
		System.out.println("Informe o peso 2:");
		p2 = sc.nextFloat();
		System.out.println("Informe a nota 3:");
		n3 = sc.nextFloat();
		System.out.println("Informe o peso 3:");
		p3 = sc.nextFloat();
		System.out.println("Media Ponderada:"+Funcoes.mediaPonderada(n1,p1,n2,p2,n3,p3));
		
		String palavra1,palavra2;
		palavra1="Hello";
		palavra2="word";
		System.out.println("junção:"+Funcoes.conct(palavra1, palavra2));
		
		System.out.println("Digite um número para verificar se é par ou impar");
		num1= sc.nextInt();
		if(Funcoes.isPar(num1))
			System.out.println("Eh par");
		else
			System.out.println("Eh impar");
		
	}
}
