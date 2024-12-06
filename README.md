Categorize trades in a bank´s portfolio

Questão 1
 - codigo desenvolvido em .NET com a última versão do C# e teste unitário com xUnit.
 - usando alguns aspectos do SOLID para facilitar a manutenção.

Questão 2

Para incluir a nova categoria PEP 
-Foi utilizado categorização extensível, onde cada categoria é implementada como uma regra independente. 
Uma nova classe de regra, pode ser criada para verificar se a propriedade IsPoliticallyExposed é true e categorizar a transação como "PEP". 
Esse código permite adicionar ou modificar categorias sem alterar as regras existentes, alinhando-se ao Princípio Open/Close , e garantindo escalabilidade e facilidade de manutenção conforme proposto na questão 1. 
