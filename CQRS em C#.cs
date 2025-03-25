using System;  // O 'using' deve ficar no início do arquivo

// Classe Item
public class Item {
    public int Id { get; set; }
    public string Nome { get; set; }
}

// Comando
public class CreateItemCommand {
    public int Id { get; set; }
    public string Nome { get; set; }
}

// Handler do Comando
public class CreateItemCommandHandler {
    public void Handle(CreateItemCommand command) {
        // Lógica para criar o item
        Console.WriteLine($"Item {command.Nome} criado com ID {command.Id}");
    }
}

// Query
public class GetItemQuery {
    public int Id { get; set; }
}

// Handler da Query
public class GetItemQueryHandler {
    public Item Handle(GetItemQuery query) {
        // Lógica para retornar o item
        return new Item { Id = query.Id, Nome = "Exemplo de Item" };
    }
}

// Ponto de entrada do programa
public class Program {
    public static void Main(string[] args) {
        // Exemplo de uso dos comandos e queries
        var createItemCommand = new CreateItemCommand { Id = 1, Nome = "Item Exemplo" };
        var createItemHandler = new CreateItemCommandHandler();
        createItemHandler.Handle(createItemCommand);

        var getItemQuery = new GetItemQuery { Id = 1 };
        var getItemQueryHandler = new GetItemQueryHandler();
        var item = getItemQueryHandler.Handle(getItemQuery);

        Console.WriteLine($"Item recuperado: {item.Nome} com ID {item.Id}");
    }
}
