package cliente;

import java.util.ArrayList;
import java.util.Scanner;

public class Cliente {
	private String nome;
	private String email;
	private String nacionalidade;
	private ArrayList<String> postagens;
	private int quantidadeDePostagem;
	private int pontuacao;
	
	public Cliente(String _nome, String _email) {
		postagens = new ArrayList<String>();
		quantidadeDePostagem = 0;
		pontuacao = 0;
		nome = _nome;
		email = _email;
	}
	
	 public int getPontuacao() {
		return pontuacao;
	}

	public String getNome() {
		return nome;
	}



	public void setNome(String nome) {
		this.nome = nome;
	}



	public String getEmail() {
		return email;
	}



	public void setEmail(String email) {
		this.email = email;
	}



	public String getNacionalidade() {
		return nacionalidade;
	}
	
	public void adicionarPostagem(String post) {
		quantidadeDePostagem++;
		
	}
	public void adicionarPontuação(int delta) {
		if(delta>=0) {
			pontuacao++;
		}else {
			System.out.println("Pontuação invalida");
		}
		
	}


	public ArrayList<String> getPostagens() {
		return postagens;
	}

	public int getQuantidadeDePostagem() {
		return quantidadeDePostagem;
	}

	public void setNacionalidade(String nacionalidade) {
		this.nacionalidade = nacionalidade;
	}
	
	public void mostrarPostagens() {
		for(int i= 0; i< postagens.size(); i++) {
			System.out.println(postagens.get(i));
		}
	}



	public static void main(String[] args) {
		ArrayList<Cliente> listaClientes = new ArrayList<Cliente>();
		char sn;
		Scanner sc = new Scanner(System.in);
		String nome, email,post;
		
		do {
			
			System.out.println("Nome:");
			nome = sc.nextLine();
			System.out.println("Email:");
			email = sc.nextLine();
			System.out.println("Post:");
			post = sc.nextLine();
			Cliente cliente = new Cliente(nome, email);
			listaClientes.add(cliente);
			System.out.println("Deseja continuar? s ou n");
			sn = sc.nextLine().charAt(0);
			
		}while(sn != 'n');
		listaClientes.get(1).mostrarPostagens();
		
		
	}
}
