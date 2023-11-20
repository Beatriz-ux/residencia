package listaNumeros;

public class GeradorPrimos {
	public static void listaDivisores(int N) {
		
		System.out.println("1");
		for (int div=2; div<(N/2);div++) {
			if(div%N ==0)
				System.out.println(div);
		}
		System.out.println(N);
		
	}
	public static int listaQTDDivisores(int N) {
		int qtd=0;
		for (int div=2; div<=(N/2);div++) {
			if(N%div ==0)
				qtd++;
		}
		//todo numero é divisivel por 1 e por ele mesmo
		return qtd+2;
		
		
	}
	
	public static boolean isPrimo(int num) {
		if(listaQTDDivisores(num)> 2) {
			return false;
		}
			
		return true;
	}
	
	public static void primosMenorIgual(int num) {
		for(int i=1; i<=num;i++) {
			if(isPrimo(i))
				System.out.println(i);
		}
	}
	public static void nPrimos(int N) {
		for(int i=1; i<=N;) {
			if(isPrimo(i)) {
				System.out.println(i);
				i++;
			}
				
		}
	}
	
	public static void main(String[] args) {
		GeradorPrimos.primosMenorIgual(10);
		System.out.println("----");
		GeradorPrimos.nPrimos(10);
	}
	
	
}
