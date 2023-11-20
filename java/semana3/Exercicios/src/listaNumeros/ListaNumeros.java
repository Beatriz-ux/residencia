package listaNumeros;
import java.util.ArrayList;
import java.util.Collections;

public class ListaNumeros {
	private ArrayList<Float> numeros;

    public ListaNumeros() {
        numeros = new ArrayList<>();
    }
    public void novoNumero(float numero) {
        numeros.add(numero);
    }
    public void listaNumeros() {
    	System.out.println("-----Números na lista-----");
    	for(float n : numeros ) {
    		System.out.println(n);
    	}
    }
    public float media() {
    	float m=0;
    	for(float n : numeros ) {
    		m=m+n;
    	}
    	m=m/(numeros.size());
    	return m;
    }
    public void ordena() {
    	Collections.sort(numeros);
    }
    public float mediana() {
    	int tamanho = numeros.size();
    	 if (tamanho % 2 == 0) {
             // Se o tamanho é par, a mediana é a média dos dois valores do meio
             int meio = tamanho / 2;
             float valor1 = numeros.get(meio - 1);
             float valor2 = numeros.get(meio);
             return (valor1 + valor2) / 2;
         } else {
             // Se o tamanho é ímpar, a mediana é o valor no meio
             return numeros.get(tamanho / 2);
         }
    }
    public void colocadoEm(int N) {
    	this.ordena();
    	int posicao = numeros.size()-(N);
    	System.out.println(N+"ésimoMAIOR:"+numeros.get(posicao));
    }
    
    public static void main(String[] args) {
		ListaNumeros l1 = new ListaNumeros();
		l1.novoNumero((float)5.0);
		l1.novoNumero((float)1.0);
		l1.novoNumero((float)10.0);
		l1.colocadoEm(2);
		
	}
}
