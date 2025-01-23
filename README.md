# dominando-testes-software
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
	
	
	
	
	
	
	
     