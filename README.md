<!-- ALL-CONTRIBUTORS-BADGE:START - Do not remove or modify this section -->
[![All Contributors](https://img.shields.io/badge/all_contributors-1-orange.svg?style=flat-square)](#contributors-)
<!-- ALL-CONTRIBUTORS-BADGE:END -->
<h1 align="center">
<img alt="LucasApoena" title="#LucasApoena" src="https://www.lucasapoena.eti.br/wp-content/uploads/2020/05/cropped-logo_lucasapoena.png" />
</h1>

<h4 align="center"> 
	🚧  Apoena.Tools.PasswordGenerator 🖖 Em Desenvolvimento 🚀 🚧
</h4>

<p align="center">
 <a href="#-sobre-o-projeto">Sobre</a> •
 <a href="#-funcionalidades">Funcionalidades</a> • 
 <a href="#-como-executar-o-projeto">Como executar</a> • 
 <a href="#-tecnologias">Tecnologias</a> • 
 <a href="#-contribuidores">Contribuidores</a> • 
 <a href="#-autor">Autor</a> • 
 <a href="#user-content--licença">Licença</a>
</p>


## 💻 Sobre o projeto

 PasswordGenerator - é uma ferramenta para criação de passwords randomicos.


Projeto desenvolvido com objetivo de estudar as estruturas do AWS Lambda.

---

## ⚙️ Funcionalidades

- [x] Gerar passwords
  - [x] Podendo definir qual o tamanho do password
  - [x] Podendo definir quais caractéres serão utilizados ao gerar o password
    - Letras maíusculas: ``A-Z``
    - Letras minusculas: ``a-z``
    - Número: ``0-9``
    - Simbolos: ``!@#$%^&*``
  

---

## 🚀 Como executar o projeto

Este projeto é divido em uma parte:
Apoena.Tools.Lambda.PasswordGenerator 

### Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:
[Git](https://git-scm.com), [.Net Core 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) e [Amazon.Lambda.Tools](https://github.com/aws/aws-extensions-for-dotnet-cli#aws-lambda-amazonlambdatools). 
Além disto é bom ter um editor para trabalhar com o código como [Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/)

#### 🎲 Rodando o Lambda

```bash
# Clone este repositório
$ git clone git@github.com:lucasapoena/Apoena.Tools.PasswordGenerator.git
# Acesse a pasta do projeto no terminal/cmd
$ cd Apoena.Tools.PasswordGenerator
# Abra o Visual Studio e execute o Mock Lambda Tool
```

---

## 🛠 Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:

#### **Lambda**  ([C# - .NET 6](#)  +  [Amazon.Lambda.Tools](#))

    - **[.NET Core 6](#)**
    - **[AWS](#)**
        - Amazon.Lambda.Core 2.1.0
        - Amazon.Lambda.Serialization.SystemTextJson 2.3.0
        - Amazon.Lambda.APIGatewayEvents 2.5.0
---


## 💪 Como contribuir para o projeto

1. Faça um **fork** do projeto.
2. Crie uma nova branch com as suas alterações: `git checkout -b my-feature`
3. Salve as alterações e crie uma mensagem de commit contando o que você fez: `git commit -m "feature: My new feature"`
4. Envie as suas alterações: `git push origin my-feature`
> Caso tenha alguma dúvida confira este [guia de como contribuir no GitHub](./CONTRIBUTING.md)
---

## 🦸 Autor

<sub><b>Lucas Apoena</b></sub></a> <a href="https://www.lucasapoena.eti.br/" title="Smile">🙂</a>
<br />

<p align="left">
    <a href="https://www.linkedin.com/in/lucasapoena/"><img src="https://img.shields.io/badge/-lucasapoena-0077B5?style=flat&logo=Linkedin&logoColor=white"/></a>
    <a href="https://medium.com/@lucasapoena"><img src="https://img.shields.io/badge/-@lucasapoena-%2312100E?style=flat&logo=medium&logoColor=white"/></a>
    <a href="mailto:contato@lucasapoena.eti.br"><img src="https://img.shields.io/badge/-contato@lucasapoena.eti.br-D14836?style=flat&logo=Gmail&logoColor=white"/></a>
</p>

---

## 📝 Licença

Este projeto esta sobe a licença [MIT](./LICENSE).

Readme baseado em: [tgmarinho/README-ecoleta](https://github.com/tgmarinho/README-ecoleta)

---


## Contributors ✨

Thanks goes to these wonderful people ([emoji key](https://allcontributors.org/docs/en/emoji-key)):

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tbody>
    <tr>
      <td align="center"><a href="https://www.lucasapoena.eti.br/"><img src="https://avatars.githubusercontent.com/u/135553?v=4?s=100" width="100px;" alt="Lucas Apoena"/><br /><sub><b>Lucas Apoena</b></sub></a><br /><a href="https://github.com/lucasapoena/Apoena.Tools.PasswordGenerator/commits?author=lucasapoena" title="Code">💻</a></td>
    </tr>
  </tbody>
</table>

<!-- markdownlint-restore -->
<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->

This project follows the [all-contributors](https://github.com/all-contributors/all-contributors) specification. Contributions of any kind welcome!
