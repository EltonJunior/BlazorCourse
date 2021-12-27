# Blazor Course

## Introduction

In this Git Page you will find some anotation by myself about Blazor tecnology and C#.
I'm use this anotations to improve my knowledge in the C# and WebApplication.

## About Blazor 

Blazor is a feature of ASP.NET, the popular web development framework that extends the .NET developer platform with tools and libraries for building web apps.

![image-of-blazor-block-diagram](blazor.png "image-of-blazor-block-diagram")

Blazor can run your client-side C# code directly in the browser, using WebAssembly. Because it's real .NET running on WebAssembly, you can re-use code and libraries from server-side parts of your application.

Alternatively, Blazor can run your client logic on the server. Client UI events are sent back to the server using SignalR - a real-time messaging framework. Once execution completes, the required UI changes are sent to the client and merged into the DOM.Tooltip: The document object model(DOM) is a programming interface that represents all elements on an HTML page as nodes in a tree structure. Using the DOM, elements can be updated, added, and removed from the page.

Blazor is a Web Framework based on standard web technologies like HTML and CSS but the technology behind it is C# instead of JavaScript which runs in the browser via WebAssembly. That is, the compiler transforms C# into WebAssembly.

The name Blazor is the Browser + Razor Mix. 



## WebAssembly (Wasm)

Wasm is an instruction set designed to run on any host that can interpret these instructions or compile them into native machine code and execute them.

Wasm is a set of instructions formatted in a specific binary format. Any host (Hardware or Software) that adheres to this specification is able to read the binaries and execute them, interpreting them directly compiling the specific machine language for the device.

Wasm is similar to the Common Intermediate Language (Common Intermediate Language) that .NET source code compiles, and like .NET, WASM can be generated from another language, such as C#.

## Framework Blazor
O Blazor é o framework para a criação de aplicações SPA interativas usando a linguagem C# que serão utilizadas em um navegador web. Com o Blazor podemos:
1- Criar UIs interativas avançadas usando C# em vez de JavaScrip.(Podemos também interagir com JS);
2- Compartilhar a lógica do aplicativo do lado do servidor e do cliente, escrita na plataforma .NET;
3- Renderizar a interface do usuário como HTML e CSS para obter amplo suporte ao navegador, incluindo navegadores móveis;

## Vantagens em usar Blazor
Usar uma plataforma .NET para desenvolvimento web do lado do cliente oferece as seguintes vantagens:
- 1- Escrever código C# em vez de JavaScript;(Assim temos acesso ao pacote LINQ e a Programação assíncrona)
- 2- Aproveitar o ecossistema .NET existente de bibliotecas da plataforma .NET;
- 3- Compartilhar a lógica do aplicativo entre servidor e cliente;
- 4- Beneficiar-se do desempenho, confiabilidade e segurança da plataforma .NET;
- 5- Manter-se produtivo com o Visual Studio no Windows, Linux e macOS;
- 6- Podemos usar o VS Code para criar aplicações usando a linha de comando;
- 7- Trabalhar com Componentes;
- 8- Interagir com o código JavaScript.

## Blzor as a Component
One of the great advantages of Blazor is that it can work with the DOM as a component, components are the central focus of Blazor.

A component is an independent piece of user interface (UI), such as a page, dialog box, graphic or formulatio that can contain logic.

A component includes HTML markup and processing logic such as:
* 1- Classes;
* 2- Methods;
* 3- Fields;
* 4- Variables;
* 5- Properties;
* 6- Loops;
* 7- Conditionals;

Everything else that is needed to inject data or respond to UI events, and this code is defined using the C# language and its syntax. 

Quando um aplicativo Blazor é compilado, a marcação HTML e as lógicas de renderização definida na Linguagem C# são convertidas em uma classe de componentes, e o nome da classe gerada corresponde ao nome do arquivo, assim, um componente é uma classe C#.

Components are implemented in files with the extension .razor, and the component name must begin with an uppercase character. ex. Counter.razor, Index.razor, etc.

Component class members are defined in an **@code** block. Components can include other components, which are declared using HTML element syntax. This tag for using a component is similar to an HTML tag, in that the tag name is the component type. ex. <Component_Name/> 

## Reference
https://github.com/AdrienTorris/awesome-blazor#books

http://www.macoratti.net/curso_blazor1.htm