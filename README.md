# Jogo Da Forca

![](https://i.imgur.com/W4fuAyW.gif)

## Projeto

- Desenvolvido durante o curso FullStack da [Academia do Programador](https://academiadoprogramador.net) 2025.

## Detalhes 

- O computador vai escolher **uma** palavra aleatoria entre **varias** possibilidades.
- O jogador deve chutar letra por letra at� acertar.
- Maximo de 5 tentativas.

## Entrada

- � solicitado ao jogador inserir uma letra por vez.
- Se a letra estiver presente na palavra ela ser� revelada na posi��o correspondente.
- Se a letra n�o estiver na palavra uma parte do boneco na forca ser� desenhada.

## Funcionalidades

- **Escolha de Palavra**: Uma palavra � escolhida aleatoriamente no inicio de cada jogo.
- **Representa��o da Forca**: A forca � desenhada progressivamente a cada erro.
- **Feedback Visual**: As letras adivinhadas s�o exibidas na posi��o correta, enquanto as n�o descobertas permanecem ocultas.
- **Contagem de Erros**: O jogo acompanha os erros cometidos e termina quando o maximo de erros � alcan�ado.

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.

## Como usar

1.Clone o repositorio ou baixe o codigo fonte.

2.Abra o terminal ou o prompt de comando e navegue at� a pasta raiz

3.Utilize o comando abaixo para restaurar as depend�ncias do projeto.
```
	dotnet restore
```

4.Em seguida, compile a solu��o utilizando o comando:
```
	dotnet build --configuration release
```

5.Ap�s isso o jogo j� deve estar disponivel para ser executado via terminal e via executavel.