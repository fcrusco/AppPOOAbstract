# Exemplo de Abstração e Polimorfismo em C#

Este projeto de console foi desenvolvido para fins didáticos, demonstrando os conceitos fundamentais de **Programação Orientada a Objetos (POO)** utilizando C#. O foco está na implementação de **Classes Abstratas**, **Herança** e **Polimorfismo**.

## 🎯 Objetivo

O sistema simula um cadastro de clientes, diferenciando Pessoa Física (PF) de Pessoa Jurídica (PJ). A arquitetura utiliza uma classe base abstrata para garantir que diferentes tipos de clientes sigam o mesmo "contrato", mantendo suas regras de validação específicas.

## 🛠️ Conceitos Aplicados

### 1. Classe Abstrata (`Cliente`)
A classe `Cliente` é marcada como `abstract`:
* **Não instanciável:** Não é possível criar um objeto `new Cliente()`.
* **Contrato:** Define o método abstrato `ValidarCadastro()`, obrigando as subclasses a implementarem sua própria lógica.
* **Reuso:** Contém o método virtual `ExibirInformacoes()`, que pode ser estendido pelas classes filhas via `base`.

### 2. Polimorfismo
No `Program.cs`, utilizamos uma variável do tipo `Cliente` para armazenar instâncias de `ClientePF` ou `ClientePJ`. Isso permite que o código trate diferentes objetos de forma genérica, invocando o comportamento correto em tempo de execução.

## 🚀 Como Executar
1. Clone o repositório.
2. Certifique-se de ter o SDK do .NET instalado.
3. Execute o comando: `dotnet run`.


----------------------------------


# C# Abstraction and Polymorphism Example

This console application was developed for educational purposes to demonstrate the fundamental concepts of **Object-Oriented Programming (OOP)** in C#. The project focuses on **Abstract Classes**, **Inheritance**, and **Polymorphism**.

## 🎯 Purpose

The system simulates a customer registration process, distinguishing between Individual (PF) and Corporate (PJ) clients. The architecture uses an abstract base class to ensure that different client types follow the same "contract" while maintaining specific validation rules.

## 🛠️ Concepts Applied

### 1. Abstract Class (`Cliente`)
The `Cliente` class is marked as `abstract`:
* **Non-instantiable:** You cannot create a `new Cliente()` object.
* **Contract:** It defines the abstract method `ValidarCadastro()`, forcing subclasses to implement their own logic.
* **Reuse:** It contains a virtual method `ExibirInformacoes()`, which can be extended by child classes using `base`.

### 2. Polymorphism
In `Program.cs`, we use a variable of type `Cliente` to store instances of either `ClientePF` or `ClientePJ`. This allows the code to handle different objects generically, invoking the correct behavior at runtime.

## 🚀 How to Run
1. Clone the repository.
2. Ensure you have the .NET SDK installed.
3. Run the command: `dotnet run`.


--------------------------------------------------------


# Ejemplo de Abstracción y Polimorfismo en C#

Esta aplicación de consola fue desarrollada con fines didácticos para demostrar los conceptos fundamentales de la **Programación Orientada a Objetos (POO)** en C#. El proyecto se centra en **Clases Abstractas**, **Herencia** y **Polimorfismo**.

## 🎯 Objetivo

El sistema simula un registro de clientes, diferenciando entre Persona Física (PF) y Persona Jurídica (PJ). La arquitectura utiliza una clase base abstracta para garantizar que los diferentes tipos de clientes sigan el mismo "contrato", manteniendo sus propias reglas de validación.

## 🛠️ Conceptos Aplicados

### 1. Clase Abstracta (`Cliente`)
La clase `Cliente` está marcada como `abstract`:
* **No instanciable:** No es posible crear un objeto `new Cliente()`.
* **Contrato:** Define el método abstracto `ValidarCadastro()`, obligando a las subclases a implementar su propia lógica.
* **Reutilización:** Contiene el método virtual `ExibirInformacoes()`, que puede ser extendido por las clases hijas mediante `base`.

### 2. Polimorfismo
En `Program.cs`, utilizamos una variable de tipo `Cliente` para almacenar instancias de `ClientePF` o `ClientePJ`. Esto permite que el código maneje diferentes objetos de forma genérica, invocando el comportamiento correcto en tiempo de ejecución.

## 🚀 Cómo Ejecutar
1. Clone el repositorio.
2. Asegúrese de tener instalado el SDK de .NET.
3. Ejecute el comando: `dotnet run`.

