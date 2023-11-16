package cliente;

import java.util.Scanner;

public class Cliente {
	private String nome;
	private int idade;
	private String cpf;
	
	public Cliente(String _nome, String _cpf) {
		this.idade = 0;
		this.cpf = _cpf;
		this.nome = _nome;
		
	}
	
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public int getIdade() {
		return idade;
	}
	public void setIdade(int idade) {
		this.idade = idade;
	}
	public String getCpf() {
		return cpf;
	}
	public void setCpf(String cpf) {
		this.cpf = cpf;
	}
	
	public static void main(String[] args) {
		System.out.println("Informe o nome:");
		Scanner sc = new Scanner(System.in);
		String nome, cpf;
		nome = sc.nextLine();
		System.out.println("Informe o CPF:");
		cpf = sc.nextLine();
		
		Cliente c1 = new Cliente (nome,cpf);
		
		System.out.println("Nome:"+ c1.getNome());
		System.out.println("Idade:"+ c1.getIdade());
		System.out.println("Cpf:"+ c1.getCpf());}
	
	
}
