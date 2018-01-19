# Sparrow Framework
Sparrow é um framework de automação de interfaces que agrega fácil utilização e abstração de complexidade dos frameworks que utilizamos para esta tarefa, seja ela web, mobile ou desktop.
Sparrow é criado na união de alguns dos principais frameworks do mercado que utilizamos e uma escrita mais simplificada e clara.

## Installing(coming soon)

## Getting Started
Você pode utilizar um console aplication ou um projeto de teste para seguir estes exemplo.

Neste exemplo estaremos utilizando a automação para web passando o browser Microsoft EDGE e o site da Google. 
Após a instalação você só precisa fazer os seguintes passos:

Adicionar as seguintes usings:
```c#
using Sparrow.Framework;
using Sparrow.Framework.Interfaces;
```

No escopo da sua classe você poderá criar a property:
```c#
private INavigationBrowser _navigation;
```

Feito isso você já pode instanciar a sua classe NavigationBrowser e começar a escrever a sua automação conforme exemplo abaixo.

Instancia da classe
```c#
_navigation = new NavigationBrowser();
```

Setup inicial da automação passando o browser e site que será testado:
```c#
_navigation.SetupTest("EDGE", "http://www.google.com.br").ExecutionTest();
```
Informando qual o tipo de elemento será procurado e o seu valor, seja ele um ID, Name, Tag Name ou qualquer outro que seja, dando um ponto para enviar o texto que deseja escrever e novamente o ponto para dar o submit no formulário.
```c#
_navigation.GetElementById("lst-ib")
                .SendKeys("Sparrow.Framework")
                .Submit();
```
E por fim você pode finalizar sua automação que realizará o fechamento do seu browser e realizará o dispose dos objetos.
```c#
_navigation.CloseBrowser();
```

Desta maneira deixo o código mais separado as ações a serem realizadas, porem como estamos utilizando fluent methods poderiamos ter escrito o código da seguinte maneira:

```c#
_navigation = new NavigationBrowser()
                .SetupTest("EDGE", "http://www.google.com.br")
                .ExecutionTest()
                .GetElementById("lst-ib")
                .GetElementById("lst-ib")
                .SendKeys("Sparrow.Framework")
                .Submit()
                .CloseBrowser();
```

Desta maneira fica uma chamada direta da instancia para todos os métodos.
