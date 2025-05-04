# ControleDeMedicamentos

![Controle De Medicamentos](https://i.imgur.com/rt0n0bi.gif)


## Introdu��o
Se voc� est� precisando de algo para gerenciar o estoque dos seus medicamentos, gerenciar
prescri��es m�dicas, etc... � exatamente aqui que voc� pode encontrar esse programa.

Permitindo que voc� gerencie com precis�o seus medicamentos, pacientes, prescri��es.
Armazenando as informa��es no seu pr�prio computador com arquivos Json.

## Como Usar
1. Menu principal cont�m as seguintes op��es:
   - *Gerenciar Fornecedores:*
      - Cadastrar Fornecedor
      - Editar Fornecedor
      - Excluir Fornecedor
      - Visualizar Fornecedores
   - *Gerenciar Funcion�rios:* 
      - Registrar Funcion�rio
      - Editar Funcion�rio
      - Excluir Funcion�rio
      - Visualizar Funcion�rios
   - *Gerenciar Medicamentos:*
      - Registrar Medicamento
      - Editar Medicamento
      - Excluir Medicamento
      - Visualizar Medicamentos
   - *Gerenciar Pacientes:*
      - Registrar Paciente
      - Editar Paciente
      - Excluir Paciente
      - Visualizar Pacientes
   - *Gerenciar Prescri��es M�dicas:*
      - Registrar Prescri��es M�dica
      - Editar Prescri��es M�dica
      - Excluir Prescri��es M�dica
      - Visualizar Prescri��es M�dicas
   - *Gerenciar Requisi��es de entrada e sa�da:*
      - Registrar Requisi��es de entrada e sa�da
      - Editar ambos os tipos
      - Excluir ambos os tipos
      - Visualizar ambos os tipos

Os dados s�o validados para garantia de que est�o corretos

## Requisitos

- .NET 9.0 para compila��o e execu��o do projeto.

## Funcionalidades

- N�o permite cadastro de pacientes com CNPJ igual ao j� cadastrado;
- N�o permite cadastrar pacientes com o mesmo cart�o SUS;
- Destaca medicamentos, declarando se est�o "Em Falta" ou "Dispon�vel";
- Atualiza automaticamente a quantidade de medicamentos caso seja cadastrado com mesmo nome;
- N�o permite que requisi��es excedam o estoque dispon�vel;
- Subtrai automaticamente a quantidade de estoque ao registrar a requisi��o;
- Valida a disponibilidade dos medicamentos no estoque;
- Alerta quando a prescri��o excede os limites permitidos;
- Exige prescri��o v�lida para requisi��es de sa�da;
- Armazena os dados em arquivos Json.
 
## Tecnologias

[![Tecnologias](https://skillicons.dev/icons?i=git,github,visualstudio,cs,dotnet)](https://skillicons.dev)

## Como Utilizar
1. *Clone o Reposit�rio:*

git clone https://github.com/P-S-T-Partido-Socialista-do-Thiagao/ControleDeMedicamentos


2. Abra o terminal ou prompt de comando e navegue at� a pasta raiz do programa.

3. Utilize o comando abaixo para restaurar as depend�ncias do projeto.

dotnet restore


4. Compile e execute o arquivo .exe do programa.

- Executar o projeto compilando em tempo real

dotnet run --project ClubeDaLeitura


# Sobre o Projeto

Este projeto foi desenvolvido como parte de um trabalho da [Academia do Programador](https://www.instagram.com/academiadoprogramador/).