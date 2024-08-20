double totalpedido = 0;
bool pedidoaberto = true;

while(pedidoaberto){
    Console.WriteLine("Sistema de gerenciamento de pedidos");
    Console.WriteLine("1 - Adicionar item ao pedido");
    Console.WriteLine("2 - Exibir o total do pedido");
    Console.WriteLine("3 - Finalizar pedido e sair");
    Console.WriteLine("Escolha uma opção:");
    string opcao = Console.ReadLine();

    switch(opcao){
        case "1":
            Console.WriteLine("Escolha um item:");
            Console.WriteLine("1 - Pizza (R$ 30.00)");
            Console.WriteLine("2 - Hamburger (R$ 15.00)");
            Console.WriteLine("3 - Refrigerante (R$ 5.00)");
            Console.WriteLine("Digite o número do item: ");
            string escolha = Console.ReadLine();

            if(escolha == "1"){
                totalpedido += 30;
            }
            
            else if(escolha == "2"){
                totalpedido += 15;
            }

            else if(escolha == "3"){
                totalpedido += 5;
            }

            else{
                Console.WriteLine("Digite um valor válido: ");
            }
            break;

        case "2":
            Console.WriteLine("Total do pedido: " + totalpedido);
            break;

        case "3":
            Console.WriteLine("Encerrando sistema!");
            pedidoaberto = false;
            break;

        default:
           Console.WriteLine("Opção inválida");
           break;
    }

}
