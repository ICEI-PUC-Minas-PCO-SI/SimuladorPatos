# SimuladorPatos

1) Código 


2) Explique quais os principais ganhos desta estratégia: 
A principal vantagem dessa estratégia é a possibilidade de reutilizar 
interfaces já existentes em diferentes classes, mantendo uma estrutura de 
função semelhante à implementada anteriormente. Isso facilita o 
reaproveitamento de código, promove a padronização e torna o 
desenvolvimento e manutenção mais ágeis. 


3) Você é capaz de ver alguma desvantagem nesta estratégia? 
Sim. Quando os métodos definidos nas interfaces utilizam void com 
saída via Console.WriteLine, a manutenção pode se tornar mais 
difícil. Isso ocorre porque qualquer alteração na lógica de saída exigiria 
modificações em todas as classes que implementam essa interface. Além 
disso, como o método não retorna valores, torna-se mais difícil reutilizar o 
resultado em outros contextos. Por outro lado, se os métodos retornassem 
valores em vez de apenas imprimir, seria possível reutilizar a lógica de 
forma mais prática e flexível em diferentes partes do código.
