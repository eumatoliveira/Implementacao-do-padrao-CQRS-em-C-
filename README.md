# Implementação do Padrão CQRS em C#

Este repositório apresenta uma **implementação simples** do padrão **CQRS (Command Query Responsibility Segregation)** utilizando C#. O CQRS tem como objetivo separar as responsabilidades de leitura e escrita de dados, criando uma estrutura mais eficiente e escalável, além de facilitar a manutenção do código.

## Estrutura do Código

O código está dividido em duas principais responsabilidades:
- **Comando (Command)**: Ação de escrita que altera o estado do sistema.
- **Consulta (Query)**: Ação de leitura que obtém dados do sistema sem modificar seu estado.

Cada uma dessas responsabilidades tem seu respectivo manipulador (Handler), que é responsável por processar a ação.

### Componentes Principais:

1. **Comando (Command)**: Representa uma ação a ser executada no sistema.
2. **Manipulador do Comando (Command Handler)**: Processa o comando e executa a lógica necessária para realizar a ação.
3. **Consulta (Query)**: Representa uma solicitação de leitura dos dados.
4. **Manipulador da Consulta (Query Handler)**: Processa a consulta e retorna os dados solicitados.

## Exemplo de Código

### 1. **Comando (Command)**

```csharp
// Comando para criar um pedido
public class CreateOrderCommand {
    public int OrderId { get; set; }
    public string Product { get; set; }
}
