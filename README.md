# Blazor Course

## Introduction

In this Git Page you will find some anotation by myself about Blazor tecnology and C#.
I'm use this anotations to improve my knowledge in the C# and WebApplication.

## About Blazor

<div>
<img id="blz-img" src="https://docs.microsoft.com/fr-fr/aspnet/core/blazor/index/_static/blazor-webassembly.png" alt="Image-Blazor-Razor-component"/>
<div>
Blazor is a feature of ASP.NET, the popular web development framework that extends the .NET developer platform with tools and libraries for building web apps.

Blazor can run your client-side C# code directly in the browser, using WebAssembly. Because it's real .NET running on WebAssembly, you can re-use code and libraries from server-side parts of your application.

Alternatively, Blazor can run your client logic on the server. Client UI events are sent back to the server using SignalR - a real-time messaging framework. Once execution completes, the required UI changes are sent to the client and merged into the DOM.Tooltip: The document object model(DOM) is a programming interface that represents all elements on an HTML page as nodes in a tree structure. Using the DOM, elements can be updated, added, and removed from the page.

Blazor is a Web Framework based on standard web technologies like HTML and CSS but the technology behind it is C# instead of JavaScript which runs in the browser via WebAssembly. That is, the compiler transforms C# into WebAssembly.

The name Blazor is the Browser + Razor Mix. 
</div>

</div>
<style>
#blz-img{
content: "";
    display: block;
    height: calc(5rem + 6vw);
    width: calc(5rem + 6vw);
    padding: 8px;
    margin: 5px;
    border-radius: 50%;
    float: left;
    shape-outside: border-box;
}
</style>


### WebAssembly (Wasm)

Wasm is an instruction set designed to run on any host that can interpret these instructions or compile them into native machine code and execute them.

Wasm is a set of instructions formatted in a specific binary format. Any host (Hardware or Software) that adheres to this specification is able to read the binaries and execute them, interpreting them directly compiling the specific machine language for the device.

Wasm is similar to the Common Intermediate Language (Common Intermediate Language) that .NET source code compiles, and like .NET, WASM can be generated from another language, such as C#.

### Framework Blazor
O Blazor é o framework para a criação de aplicações SPA interativas usando a linguagem C# que serão utilizadas em um navegador web. Com o Blazor podemos:
1- Criar UIs interativas avançadas usando C# em vez de JavaScrip.(Podemos também interagir com JS);
2- Compartilhar a lógica do aplicativo do lado do servidor e do cliente, escrita na plataforma .NET;
3- Renderizar a interface do usuário como HTML e CSS para obter amplo suporte ao navegador, incluindo navegadores móveis;

#### Vantagens em usar Blazor
Usar uma plataforma .NET para desenvolvimento web do lado do cliente oferece as seguintes vantagens:
1- Escrever código C# em vez de JavaScript;(Assim temos acesso ao pacote LINQ e a Programação assíncrona)
2- Aproveitar o ecossistema .NET existente de bibliotecas da plataforma .NET;
3- Compartilhar a lógica do aplicativo entre servidor e cliente;
4- Beneficiar-se do desempenho, confiabilidade e segurança da plataforma .NET;
5- Manter-se produtivo com o Visual Studio no Windows, Linux e macOS;
6- Podemos usar o VS Code para criar aplicações usando a linha de comando;
7- Trabalhar com Componentes;
8- Interagir com o código JavaScript.


# Reference
https://github.com/AdrienTorris/awesome-blazor#books
http://www.macoratti.net/curso_blazor1.htm