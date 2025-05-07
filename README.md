# Ciot

Sistema desenvolvido em **ASP.NET Core 9** com frontend em **React + Vite**.

---

## Telas 

![image](https://github.com/user-attachments/assets/33e79858-ca7d-495d-96ec-7c3d27d98c0f)

![image](https://github.com/user-attachments/assets/88d38dc0-0aaf-456e-84c1-cffa55a3abcb)


---

## 📦 Estrutura do Projeto

- **Ciot.Core** → Entidades básicas do domínio.
- **Ciot.Application** → Camada de aplicação, responsável pela lógica de negócios.
- **Ciot.Data** → Camada de dados usando Entity Framework InMemory.
- **Ciot.Web** → Projeto web ASP.NET Core.
- **Ciot.Web/App** → Frontend React, com Vite como bundler e TanStack Router para gerenciamento de rotas.

#### Bibliotecas e frameworks utilizados no frontend:
- **React**
- **TanStack Router**
- **Valibot**
- **Vite**

---

## ✅ Pré-requisitos

- [.NET 9](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Node.js (LTS)](https://nodejs.org/en/download/)

---

## 💻 Instalando dependências

### Backend (.NET)

1. Abra um terminal na raiz do projeto.
2. Instale as dependências do backend:
   ```bash
   dotnet restore
   ```
---

### Frontend (React + Vite)

---

### `api/`

Implementação simples de utilização de APIs:

- `auth.ts` → chamadas para rotas de autenticação.
- `devices.ts` → chamads para rotas que serve os dispositivos.
- `index.ts` → agregador das chamadas.

---

### `components/`

Componentes React:

- `Layout.tsx` → estrutura principal da página (header, footer, sidebar).
- `OperationItem.tsx` → item individual do painel de operações.
- `OperationsPanel.tsx` → painel que lista operações.
- `SideBar.tsx` → barra lateral de navegação.

---

### `config/`

Configuração da aplicação:

- `router.ts` → configuração das rotas com TanStack Router.
- `urls.ts` → constantes com URLs usados no frontend.

---

### `exceptions/`

Tratamento de exceções e erros:

- `NetworkError.ts` → definição de erros relacionados à rede.

---

### `routes/`

Definição das Rotas (TanStack Router):

- `__root.tsx` → rota raiz.
- `_protected.tsx` → layout para rotas protegidas.
- `_protected.device.$id.tsx` → apresentação das informaçoes do dispositivo bem como suas operaçoes.
- `_protected.index.tsx` → página inicial de rotas protegidas.
- `_protected.signout.tsx` → rota para fazer logout.
- `login.tsx` → página de login.

---

### `schemas/`

Modelos de validação (provavelmente usando **Valibot** ou **Zod**) para dados de entrada e saída:

- `DeviceSchema.ts` → validação de dados de dispositivos.
- `ItemSchema.ts` → validação de itens.
- `LocalStorageSchema.ts` → dados no localStorage.
- `LoginInputSchema.ts` → dados do formulário de login.
- `LoginResponseSchema.ts` → resposta do login.
- `UserSchema.ts` → dados do usuário.
- `index.ts` → agregador de schemas.

---

### Arquivos de nível raiz

- `index.tsx` → ponto de entrada da aplicação frontend.
- `routeTree.gen.ts` → árvore de rotas gerada automaticamente pelo TanStack Router.

---

### Inicialização do Frontend

1. Navegue até a pasta `Ciot.Web/App`.
2. Instale as dependências:
   ```bash
   npm install
   ```

---

## ⚙️ Build do Frontend

O projeto frontend está configurado para gerar os arquivos estáticos na pasta `Ciot.Web/wwwroot`, que é servida pelo ASP.NET Core.

Para gerar o build:
```bash
npm run build
```

Isso compilará os arquivos React e os copiará automaticamente para `Ciot.Web/wwwroot`.

---

## 🚀 Modo Desenvolvimento

Para desenvolvimento local com atualização automática:

1. Na pasta `Ciot.Web/App`, execute:
   ```bash
   npm run dev
   ```

O **Vite** ficará em modo watch, monitorando mudanças e atualizando automaticamente o build no backend.

2. Em outro terminal, na raiz do projeto:
   ```bash
   dotnet run
   ```

O backend ASP.NET Core rodará e servirá a aplicação.

---

## 🔑 Usuários de exemplo

O sistema vem com usuários pré-cadastrados:

| Email                  | Senha  |
|------------------------|--------|
| johndoe@ciot.io       | admin  |
| jose@ciot.io          | admin  |
| janesmith@ciot.io     | admin  |
| afonsoribeiro@ciot.io | admin  |
| maria@ciot.io         | admin  |

O nome de usuário é o próprio email.

---

## 🧪 Testes

❗ O projeto **não possui testes automatizados** no momento.  
A decisão foi priorizar a entrega das funcionalidades principais devido a restrições de tempo.

---

## 💡 Decisões Técnicas

- **ASP.NET Core 9**: Framework moderno, leve e performático para backend.
- **Entity Framework InMemory (Ciot.Data)**: Permite simular o banco de dados em memória, facilitando o desenvolvimento sem configuração de banco.
- **Camadas separadas (Core, Application, Data)**: Arquitetura limpa, facilita manutenção.
- **React + Vite no Frontend**: Praticamente um padrão de mercado no desenvolvimento frontend.
- **TanStack Router**: Router moderno, baseado em hooks, com ótimo suporte a rotas aninhadas.
- **Valibot**: Biblioteca de validação leve para formulários e inputs.

---

## 📥 Como Rodar (Resumo Final)

```bash
# Backend
dotnet restore
dotnet run

# Frontend
cd Ciot.Web/App
npm install
npm run dev  # ou npm run build para produção
```

---

## 📃 Licença

Projeto de exemplo, sem licença específica.
