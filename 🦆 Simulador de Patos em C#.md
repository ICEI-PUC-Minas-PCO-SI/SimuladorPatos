# 🦆 Simulador de Patos em C#

Este projeto é uma implementação simples de um simulador de patos utilizando os conceitos de **Programação Orientada a Objetos (POO)**.

---

## 📘 Pergunta 2: Quais os principais ganhos desta estratégia?

Os principais **benefícios** ao utilizar interfaces para comportamentos que variam são:

- **Flexibilidade e reutilização**: Permite a criação de diferentes tipos de pato combinando comportamentos específicos (ex: pato que não voa, mas grasna).
- **Baixo acoplamento**: A classe `Duck` não depende diretamente das implementações dos comportamentos.
- **Facilidade de manutenção**: Novos comportamentos podem ser adicionados sem alterar o código existente.

---

## ⚠️ Pergunta 3: Há alguma desvantagem nesta estratégia?

Sim, apesar das vantagens, existem **desvantagens potenciais**:

- **Complexidade adicional**: A estrutura do código pode ficar mais complexa com muitas interfaces e classes.
- **Sobrecarga de código**: Para projetos muito simples, a separação em muitas interfaces pode parecer exagerada.
- **Checagem de tipo em tempo de execução**: Precisamos verificar se um objeto implementa determinada interface (`is IFlyable`), o que pode deixar o código menos direto.

---

## ❓ Pergunta extra:

> **Se a utilização de interfaces em C# permite comportamentos similares à herança (como obrigar uma classe a implementar métodos), e considerando que C# não permite herança múltipla de classes, por que ainda assim preferimos usar interfaces em vez de apenas herança simples?**

Embora herança e interfaces compartilhem algumas funcionalidades — como padronizar métodos em várias classes — elas têm propósitos e aplicações distintas:

### ✅ Vantagens das interfaces sobre a herança simples:

- **Herança múltipla não é permitida em C#, mas múltiplas interfaces são.** Isso possibilita compor comportamentos diversos sem depender de uma única hierarquia.
- Interfaces representam **habilidades ou comportamentos** (ex: voar, emitir som), e não uma identidade. Já herança define o que uma classe **é** (ex: é um tipo de pato).
- **Baixo acoplamento:** Interfaces promovem uma arquitetura mais desacoplada, facilitando mudanças futuras.
- **Testabilidade:** Interfaces são essenciais para aplicar boas práticas de testes, como mocks e injeção de dependência.
- São amplamente usadas em **padrões de projeto (Design Patterns)** como Strategy, Observer e Decorator, o que torna o código mais reutilizável e escalável.

### ❌ Limitações da herança simples:

- A herança **acopla fortemente** as classes, o que pode dificultar alterações e manutenções.
- Permite **apenas uma superclasse**, limitando a composição de comportamentos.
- Nem sempre faz sentido conceitualmente: um pato de borracha pode não voar nem grasnar, mas ainda é um pato — ele **não deveria herdar comportamentos que não possui**.

---

## 🛠️ Tecnologias

- Linguagem: C#
- Projeto Console com `.NET SDK`
- Editor sugerido: Visual Studio Code

---

## 🧪 Como executar

```bash
dotnet run
