# 1. O que é uma classe em Java e qual é a diferença entre uma classe e um objeto?

> Fazendo uma analogia, uma classe seria como uma forma de um bolo e o objeto seria um bolo de chocolate. 
> 
> De forma conceitual uma classe é uma estrutura/modelo que representa um objeto do mundo real de forma abstrata, nela contém atributos (pode ser considerado como as caracteristicas do objeto) e métodos (ações que o objeto pode executar ou comportamentos), enquando o objeto é uma instancia da classe com valores específicos para seus atributos.

## Exemplos de Classes

### Classe `Carro`

-  C++

```cpp
class Carro {
    private:
        string modelo;
        int ano;
    public:
        void acelerar() {
            // implementação
        }

        void frear() {
            // implementação
        }
}
```

- Java

```java
public class Carro {
    private String modelo;
    private int ano;

    public void acelerar() {
        // implementação
    }

    public void frear() {
        // implementação
    }
}
```

### Classe `Pessoa`

- C++

```cpp
class Pessoa {
    private:
        string nome;
        int idade;

    public: 
        void cumprimentar() {
            // implementação
        }
}
```

- Java

```java
public class Pessoa {
    private String nome;
    private int idade;

    public void cumprimentar() {
        // implementação
    }
}
```

### Classe `Círculo`

- C++

```cpp
class Circulo {
    private:
        double raio;

    public:
        double calcularArea() {
            // implementação
        }
}
```

- Java

```java
public class Circulo {
    private double raio;

    private double calcularArea() {
        // implementação
    }
}
```

### Classe `Livro`

- C++

```cpp
class Livro {
    private:
        string titulo;
        string autor;

    public:
        void ler() {
            // implementação
        }
}
```

- Java

```java
public class Livro {
    private String titulo;
    private String autor;

    public void ler() {
        // implementação
    }
}
```

### Classe `ContaBancaria`

- C++

```cpp
class ContaBancaria {
    private:
        string titular;
        double saldo;

    public:
        void depositar(double valor) {
            // implementação
        }

        void sacar(double valor) {
            // implementação
        }
}
```

- Java

```java
public class ContaBancaria {
    private String titular;
    private double saldo;

    private void depositar(double valor) {
        // implementação
    }

    private void sacar(double valor) {
        // implementação
    }
}
```

# 2. Como você declara uma variável em Java e quais são os tipos de dados primitivos mais comuns? 

> Em Java, os tipos de dados primitivos mais comuns incluem int para números inteiros, double para números decimais, boolean para valores booleanos e char para caracteres. Em C++, esses tipos são semelhantes, mas há a diferença de que o tipo bool é usado em vez de boolean e a classe std::string é usada para representar strings em vez do tipo primitivo String do Java.

- C++

```cpp
// Declaração de variável em C++
int idade; // Exemplo de variável do tipo inteiro

// Tipos de dados primitivos comuns em C++
int numeroInteiro;
double numeroDecimal;
bool booleano;
char caractere;
```

- Java

```java
// Declaração de variável em Java
int idade; // Exemplo de variável do tipo inteiro

// Tipos de dados primitivos comuns em Java
int numeroInteiro;
double numeroDecimal;
boolean booleano;
char caractere;
```

# 3. Explique o conceito de herança em Java e como você pode criar uma subclasse a partir de uma classe existente.

> A herança é um conceito fundamental da programação orientada a objetos, que permite que uma classe (subclasse) herde atributos e métodos de outra classe (superclasse). A subclasse pode adicionar ou modificar comportamentos sem alterar a classe pai. Para criar uma subclasse em Java, utiliza-se a palavra-chave extends.

```java
// Classe pai (superclasse)
class Animal {
    void fazerSom() {
        System.out.println("Som genérico de animal");
    }
}

// Subclasse que herda de Animal
class Gato extends Animal {
    void fazerSom() {
        System.out.println("Miau");
    }
}
```

## Herança Simples:

- C++

```cpp
class A { /* ... */ };
class B : public A { /* ... */ };
```

- Java

```java
class A { /* ... */ }
class B extends A { /* ... */ }
```

## Herança Múltipla :

- C++

```cpp
class A { /* ... */ };
class B { /* ... */ };
class C : public A, public B { /* ... */ };
```


- Java

```java
// Não possui
```

## Herança com Construtores:

- C++

```cpp
class A { A(int x) { /* ... */ } };
class B : public A { B(int y) : A(y) { /* ... */ } };
```


- Java

```java
class A { A(int x) { /* ... */ } }
class B extends A { B(int y) { super(y); /* ... */ } }
```

## Herança Protegida:

- C++
```cpp
class A { protected: /* ... */ };
class B : A { /* ... */ };
```


- Java

```java
class A { /* ... */ }
class B extends A { /* ... */ }
```

## Polimorfismo:

- C++

```cpp
class A { public: virtual void metodo() { /* ... */ } };
class B : public A { public: void metodo() override { /* ... */ } };
```

- Java

```java
class A { void metodo() { /* ... */ } }
class B extends A { void metodo() { /* ... */ } }
```

# 4. Quando declaramos uma variável em Java, temos, na verdade, um ponteiro. Em C++ é diferente.

## Variáveis:

> Variáveis em C++ contêm um valor que pode ser um objeto ou um tipo primitivo. Se olharmos o equivalente em Java, estamos nos referindo aos tipos primitivos. Por exemplo:

```cpp
int i = 0;
```
## Ponteiros

> Em C++, ponteiros são variáveis que armazenam o endereço de outras variáveis. No contexto de Java, não há um equivalente direto para ponteiros. 
>
> Em Java, quando declaramos uma variável de um tipo de objeto (não um tipo primitivo), na verdade estamos criando uma referência ou um ponteiro para um objeto na memória. Em termos simples, essa variável contém a referência para a localização de memória onde o objeto está armazenado.