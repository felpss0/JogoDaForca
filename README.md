# Jogo Da Forca

![](https://i.imgur.com/W4fuAyW.gif)

## Projeto

- Desenvolvido durante o curso FullStack da [Academia do Programador](https://academiadoprogramador.net) 2025.

## Detalhes 

- O computador vai escolher **uma** palavra aleatoria entre **varias** possibilidades.
- O jogador deve chutar letra por letra até acertar.
- Maximo de 5 tentativas.

## Entrada

- É solicitado ao jogador inserir uma letra por vez.
- Se a letra estiver presente na palavra ela será revelada na posição correspondente.
- Se a letra não estiver na palavra uma parte do boneco na forca será desenhada.

## Funcionalidades

- **Escolha de Palavra**: Uma palavra é escolhida aleatoriamente no inicio de cada jogo.
- **Representação da Forca**: A forca é desenhada progressivamente a cada erro.
- **Feedback Visual**: As letras adivinhadas são exibidas na posição correta, enquanto as não descobertas permanecem ocultas.
- **Contagem de Erros**: O jogo acompanha os erros cometidos e termina quando o maximo de erros é alcançado.

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.

## Como usar

1.Clone o repositorio ou baixe o codigo fonte.

2.Abra o terminal ou o prompt de comando e navegue até a pasta raiz

3.Utilize o comando abaixo para restaurar as dependências do projeto.
```
	dotnet restore
```

4.Em seguida, compile a solução utilizando o comando:
```
	dotnet build --configuration release
```

5.Após isso o jogo já deve estar disponivel para ser executado via terminal e via executavel.