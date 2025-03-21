# TaskSystem

![GitHub](https://https://github.com/dkderyk/TaskSystem)

O **TaskSystem** é um sistema de gerenciamento de tarefas desenvolvido em .NET 8, utilizando Entity Framework e SQL Server. Projetado para simplificar a organização e acompanhamento de atividades individuais ou em equipe, oferece uma solução robusta e escalável para gestão de produtividade.

---

## Funcionalidades Principais

- **Gerenciamento de Tarefas**:
  - Criação de tarefas com título, descrição e status
  - Atualização de status (Pendente/Em Andamento/Concluída)
  - Atribuição de tarefas a usuários específicos

- **API RESTful**:
  - Endpoints documentados com Swager
  - Suporte a paginação e filtros avançados

---

## Tecnologias Utilizadas

- **Backend**: .NET 8 + ASP.NET Core
- **ORM**: Entity Framework Core
- **Banco de Dados**: Microsoft SQL Server (LocalDB)

---

## Pré-requisitos

- .NET 8 SDK
- SQL Server (ou SQL Server Express/LocalDB)
- Entity Framework Core CLI
- Visual Studio 2022 ou VS Code (recomendado)

---

## Instalação e Configuração

1. **Clonar o Repositório**:
   ```bash
   git clone https://github.com/dkderyk/TaskSystem.git
   cd TaskSystem
