package quiz;

import java.util.ArrayList;
import java.util.Scanner;

public class Pergunta {
	private String pergunta;
	private String[] alternativas = new String[4];
	private int certa;
	
	
	public Pergunta(String pergunta, String[] alternativas, int certa) {
		super();
		this.pergunta = pergunta;
		this.alternativas = alternativas;
		this.certa = certa;
	}
	public Pergunta() {
		super();
	}
	public String getPergunta() {
		return pergunta;
	}
	public void setPergunta(String pergunta) {
		this.pergunta = pergunta;
	}
	public String[] getAlternativas() {
		return alternativas;
	}
	public void setAlternativas(String[] alternativas) {
		this.alternativas = alternativas;
	}
	public int getCerta() {
		return certa;
	}
	public void setCerta(int certa) {
		this.certa = certa;
	}
	public void criarPergunta(String pergunta, String[] alternativas, int certa) {
		this.pergunta = pergunta;
		this.alternativas = alternativas;
		this.certa = certa;
	}
	public static void adicionarPergunta(ArrayList<Pergunta> perguntas,Pergunta p) {
		perguntas.add(p);
	}
	
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int resp=0;
		ArrayList<Pergunta> perguntas = new ArrayList<>();
		
		do {
			System.out.println("Deseja adicionar uma pergunta? 1-sim 0-Não");
			resp=sc.nextInt();
			sc.nextLine();
			if(resp==1) {
				Pergunta p = new Pergunta();
				String enunciado;
				String [] alternativas = new String[4];
				int correta;
				System.out.println("Qual o enunciado da pergunta?");
				enunciado = sc.nextLine();
				for(int i=0;i<4;i++) {
					System.out.println("Qual o enunciado da alternativa " + (i+1) + " ?");
					alternativas[i]=sc.nextLine();
				}
				System.out.println("Qual a alternativa correta?");
				correta = sc.nextInt();
				p.criarPergunta(enunciado,alternativas, correta);
				perguntas.add(p);
			}
		}while(resp != 0);
		Pergunta pergunta1 = new Pergunta("Quem foi o primeiro presidente dos Estados Unidos?",
		        new String[]{"George Washington", "Thomas Jefferson", "Abraham Lincoln", "John F. Kennedy"}, 0);

		Pergunta pergunta2 = new Pergunta("Qual é a velocidade da luz no vácuo?",
		        new String[]{"299.792.458 metros por segundo", "300.000.000 metros por segundo", "200.000.000 metros por segundo", "250.000.000 metros por segundo"}, 0);

        Pergunta pergunta3 = new Pergunta("Qual é o maior planeta do sistema solar?",
                new String[]{"Terra", "Júpiter", "Marte", "Saturno"}, 1);
       
        Pergunta pergunta4 = new Pergunta("Quem pintou a Mona Lisa?",
                new String[]{"Leonardo da Vinci", "Michelangelo", "Rafael", "Pablo Picasso"}, 0);

        Pergunta pergunta5 = new Pergunta("Qual é o rio mais longo do mundo?",
                new String[]{"Rio Nilo", "Rio Amazonas", "Rio Yangtzé", "Rio Mississipi"}, 1);
        
        Pergunta pergunta6 = new Pergunta("Quem escreveu 'Dom Quixote'?",
                new String[]{"Miguel de Cervantes", "Gabriel García Márquez", "Jorge Luis Borges", "Fernando Pessoa"}, 0);
        
        perguntas.add(pergunta1);
        perguntas.add(pergunta2);
        perguntas.add(pergunta3);
        perguntas.add(pergunta4);
        perguntas.add(pergunta5);
        perguntas.add(pergunta6);


		int qtdCerta=0;
		System.out.println("------Quiz----------");
		for (Pergunta elemento : perguntas) {
			int resposta;
			int cont=0;
			String[] alter = new String[4];
			alter = elemento.getAlternativas();
			System.out.println(elemento.getPergunta());
            
            for (String e : alter) {
            	System.out.println((cont+1)+")"+e);
            	cont++;
            }
            System.out.println("Qual a alternativa correta?");
            resposta = sc.nextInt();
            
            if((resposta -1) == elemento.getCerta()) {
            	System.out.println("Acertou");
            	qtdCerta++;
            }else {
            	System.out.println("errou, alternativa correta:" + (elemento.getCerta()+1));
            }
        }
		System.out.println("Você acertou " + qtdCerta+ "questões");
		
		
		
	}
	
}
