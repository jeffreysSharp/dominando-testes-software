# Dominando-testes-software
Curso Dominando Testes de Software em desenvolvedor.io

# xUnit
* Escrito pelos criadores do NUnit
* Compatível com Visual Studio
* Utilizado pelo time de Desenvolvimento do .NET Core e ASP.NET

- Instalação do Framework
  PM> Install-Package xuni
  
- Instalação para reconhecimento do Visual Studio
  PM Install-Package xunit xunit.runner.visualstudio

# Testes de Unidade
* Padões e Nomenclaturas
  AAA  - Arrange, Act, Assert  
  
  // Arrange - Manipulação do Objeto a ser Testado
  // Act - chamada do método a ser testado
  // Assert - Validar o resultado da chamada comparando com os comportamentos 
  
* Nomenclatura de Testes de Unidade

  ObjetoEmTeste_MetodoComportamentoEmTeste_ComportamentoEsperado
	Pedido_AdicionarPedidoItem_DeveIncrementarUnidadesSeItemJaExistente
	Estoque_RetirarItem_DeveEnviarEmailSeAbaixode10Unidades
	
  MetodoEmTeste_EstadoEmTeste_ComportamentoEsperado
    AdicionarPedidoItem_ItemExistenteCarrinho_DeveIncrementarUnidadesDoItem
	RetirarItemEstoque_EstoqueAbaixoDe10Unidades_DeveEnviarEmailDeAviso
	
* A Importância do Mock
  Objetos Mock, objetos simulados ou simplesmente Mock (Mock Object)
são objetos que simulam o comportamento de objetos reais de forma controlada.

São normalmente criados para testar o comportamento de outros objetos. Em outras palavras,
os objetos mock são objetos "falsos" que simulam o comportamento de uma classe ou objeto "real"
para que possamos focar o teste na unidade a ser testada.

Uma vantagem do Mock é que o objeto simulado pode ser criado dinamicamente através de um framework de Mocke poupando o desenvolvedor
ter que criar uma classe física para simular aquele objeto.

Uma classe física quye simula o objeto costuma ser chamada de Fake, mas na teoria é um Mock,
a diferença é que foi criada manualmente.

  
	
	
	
	
	
     