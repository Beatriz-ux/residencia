package verbo;
import java.util.Scanner;

public class Verbo {
	private String radical,sufixo;
	
	
	
	public Verbo(String radical, String sufixo) {
		super();
		this.radical = radical;
		this.sufixo = sufixo;
	}
	public Verbo () {
		Scanner sc = new Scanner(System.in);
		System.out.println("Qual o radical?");
		radical = sc.nextLine();
		System.out.println("Qual o radical?");
		sufixo = sc.nextLine();
		
		
		
		
	}

	public void conjugar() {
		System.out.println("Eu " + radical +"o");
		System.out.println("Tu " + radical +"as");
		System.out.println("Ele " + radical +"a");
		System.out.println("Nós " + radical +"amos");
		System.out.println("Vós " + radical +"ais");
		System.out.println("Eles " + radical +"am");
		
		
	}
	
	public String getRadical() {
		return this.radical;
	}
	
	public String getSufixo() {
		return sufixo;
	}
	
	public void setSufixo(String sufixo) {
		this.sufixo = sufixo;
	}
	
	public void setRadical(String radical) {
		this.radical = radical;
	}
	
	public static void main(String[] args) {
		Verbo verbo = new Verbo(); 
		
		verbo.conjugar();
	}
}
