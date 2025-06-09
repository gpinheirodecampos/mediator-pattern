# Padrão Mediator - Aplicação Console C#

Uma implementação simples do padrão de projeto **Mediator** em C# que simula duas janelas com caixas de texto e botões, onde o texto pode ser copiado de uma janela para outra.

## Descrição

Esta aplicação console demonstra o padrão Mediator através de uma simulação onde:
- Duas janelas podem receber texto digitado
- Cada janela possui um "botão" que copia seu texto para a outra janela
- Toda comunicação entre as janelas é mediada por um objeto central (ConcreteMediator)

## Estrutura do Projeto

```
├── IMediator.cs           # Interface do mediador
├── Window.cs              # Classe abstrata base para as janelas
├── ConcreteMediator.cs    # Implementação concreta do mediador
├── Window1.cs             # Primeira janela
├── Window2.cs             # Segunda janela
├── Program.cs             # Classe principal
└── README.md              # Este arquivo
```

## Como Executar

1. Certifique-se de ter o .NET 9.0 instalado
2. Clone ou baixe o projeto
3. No diretório do projeto, execute:

```bash
dotnet run
```

## Como Usar

A aplicação oferece os seguintes comandos:

- `1 <texto>` - Digita texto na Janela 1
- `2 <texto>` - Digita texto na Janela 2
- `b1` - Pressiona o botão da Janela 1 (copia texto para a Janela 2)
- `b2` - Pressiona o botão da Janela 2 (copia texto para a Janela 1)
- `sair` - Encerra a aplicação

### Exemplo de Uso

```
=== Aplicação com Padrão Mediator ===
Comandos: 1 <texto> | 2 <texto> | b1 | b2 | sair

1 Olá mundo
Janela 1 - Texto digitado: Olá mundo
Estado atual - Janela 1: 'Olá mundo' | Janela 2: ''

b1
Texto copiado da Janela 1 para Janela 2: Olá mundo
Estado atual - Janela 1: 'Olá mundo' | Janela 2: 'Olá mundo'

2 Novo texto
Janela 2 - Texto digitado: Novo texto
Estado atual - Janela 1: 'Olá mundo' | Janela 2: 'Novo texto'

b2
Texto copiado da Janela 2 para Janela 1: Novo texto
Estado atual - Janela 1: 'Novo texto' | Janela 2: 'Novo texto'
```

## Padrão Mediator

O padrão Mediator define como um conjunto de objetos interage entre si. Em vez de os objetos se comunicarem diretamente, eles se comunicam através de um mediador central.

### Componentes:

- **IMediator**: Interface que define as operações de mediação
- **ConcreteMediator**: Implementa a lógica de mediação entre as janelas
- **Window**: Classe abstrata que representa uma janela genérica
- **Window1/Window2**: Implementações específicas das janelas

### Benefícios:

- **Baixo acoplamento**: As janelas não conhecem umas às outras diretamente
- **Reutilização**: O código das janelas pode ser reutilizado facilmente
- **Manutenibilidade**: Mudanças na lógica de comunicação ficam centralizadas no mediador
