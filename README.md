# ⚓ Âncora – Esperança que sustenta

### Esperança firme da Palavra para a alma.

Âncora é uma aplicação web e mobile-first criada para ajudar pessoas a encontrarem apoio, esperança, direção e firmeza na Palavra de Deus — tanto em momentos de tempestade quanto em momentos serenos, quando precisamos relembrar o amor, as promessas e o cuidado do Senhor para conosco.

Nossa base inspiradora está em Hebreus 6:17-19:

> “Deus quis deixar bem claro aos que iam receber o que ele havia prometido que jamais mudaria a sua decisão. Por isso, junto com a promessa, fez o juramento. Portanto, há duas coisas que não podem ser mudadas, e a respeito delas Deus não pode mentir. E assim nós, que encontramos segurança nele, nos sentimos muito encorajados a nos manter firmes na esperança que nos foi dada. Essa esperança mantém segura e firme a nossa vida, assim como a âncora mantém seguro o barco. Ela passa pela cortina do templo do céu e entra no Lugar Santíssimo celestial.”

A Âncora da Alma representa a esperança nas promessas imutáveis de Deus, trazendo estabilidade, segurança interior e direção espiritual em qualquer circunstância.

Este projeto nasce com o propósito de conectar nossas emoções humanas à verdade eterna das Escrituras, oferecendo reflexões bíblicas personalizadas com uma abordagem acolhedora, equilibrada e fundamentada.

---
## 🧠 Proposta de Valor

Muitas pessoas sabem que a Bíblia é a Palavra revelada de Deus para nos orientar e nos manter de pé, e que nela estão as promessas e revelações do Senhor para as nossas vidas. No entanto, em meio às pressões do dia a dia, às emoções intensas ou às circunstâncias difíceis, nem sempre é fácil lembrar ou encontrar rapidamente o que o Pai diz sobre aquilo que estamos passando ou sentindo.

Âncora nasce para auxiliar nesse processo, oferecendo:

- Direcionamento espiritual contextualizado
- Linguagem acolhedora e pastoral
- Aplicações práticas para o dia a dia
- Simplicidade e clareza na experiência
- Base bíblica sólida

---
## ✨ Visão de Produto

A aplicação permitirá que o usuário:

- Selecione uma emoção (ansiedade, medo, tristeza, gratidão, esperança, etc.)
- Receba uma reflexão bíblica personalizada
- Leia uma explicação clara e equilibrada do texto
- Aplique a mensagem à sua realidade prática
- Encontre encorajamento fundamentado na Palavra

---

## 🏗 Arquitetura do projeto

O projeto segue os princípios de **Clean Architecture**, garantindo separação de responsabilidades, escalabilidade e manutenção facilitada.

```
src/
└── Backend/
  ├── Anchor.API
  ├── Anchor.Application
  ├── Anchor.Domain
  └── Anchor.Infrastructure
└── Shared/
  ├── Anchor.Communication
  ├── Anchor.Exceptions
```

### 📦 Camadas

**Anchor.Domain**
- Entidades
- Regras de negócio
- Contratos base

**Anchor.Application**
- Casos de uso
- DTOs
- Interfaces de serviços
- Orquestração de regras

**Anchor.Infrastructure**
- Persistência (Entity Framework Core)
- Integrações externas (API Bíblica, OpenAI)
- Implementações concretas

**Anchor.API**
- Controllers
- Configuração
- Injeção de dependência
- Exposição dos endpoints REST

---

## 🚀 Tecnologias

- .NET 8
- ASP.NET Core
- Entity Framework Core
- SQL Server
- Docker
- API Bíblica (integração planejada para leitura das passagens)
- OpenAI API (para geração de aplicações práticas da palavra no seu dia)

---

## 🐳 Ambiente de Desenvolvimento

A aplicação pode ser executada:

- Localmente via `dotnet run`
- Utilizando Docker
- Com banco de dados rodando via container

O projeto já possui Dockerfile configurado na camada da API.

---

## 📌 Status

🚧 Em desenvolvimento (fase MVP)

---

## 🤝 Propósito

Âncora não é apenas um projeto técnico.

É uma ferramenta para cuidar da alma, fortalecendo pessoas por meio da esperança firme nas promessas de Deus.

---

Desenvolvido com propósito. 📖🌱