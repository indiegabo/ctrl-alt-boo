# Contribuição para a ctrl-alt-boo

## Proposta

Para caso alguém resolva utilizar Unity:

A ideia dessa mecânica inspirada no jogo [Darkwood](https://store.steampowered.com/app/274520/Darkwood/) é permitir que elementos estejam escondidos na cena e apenas quando estiverem no campo de visão do player ficarão visíveis. Permite criar uma atmosfera sombria e recheada de suspense. 

Abaixo você pode perceber um exemplo demonstrando como pode funcionar.

## Exemplo

https://user-images.githubusercontent.com/95456621/197367652-04ccbd4d-fa40-485b-9cda-a5500aa1967b.mp4

## Como funciona

Na pasta "Assets/_Project/Materials" você vai encontrar o material "HideInShadow". Utilize ele em qualquer sprite que você quiser que fique completamente apagada na cena caso nenhuma iluminação a afete. Daí é só utilizar esse material em qualquer SpriteRenderer que você queira causar efeito.

Note que para que funcione o SpriteRenderer em questão deve estar configurado para uma Sorting Layer que não seja afetada por nenhuma outra luz que a do campo de visão (FOV - Field of view) do player. Dá uma olhada nos exemplos abaixo (retirados da cena exemplo nesse projeto).

![Sorting Layer](https://user-images.githubusercontent.com/95456621/197368048-173ba7df-84fa-4b93-b4e1-fc6740ff582c.jpg)

![FOV - Light](https://user-images.githubusercontent.com/95456621/197368095-c10a7f98-7b84-4ba9-bab1-f1f15e7f03df.jpg)

Note que apenas luzes que definem o campo de visão do player deverão estar com a Sorting Layer definida pro FOV marcada. Todas as outras luzes devem desmarcar essa Sorting Layer.

## Importando apenas o que interessa

Se não quiser baixar o projeto para fazer sua própria extração, tá aqui o link para download do pacote da Unity: ![Hide In Shadow Package](https://drive.google.com/file/d/1R16Hj4wnkBdlOpAXtfkVIIQeCQYyPsP1/view?usp=sharing) .

**OBS:** O arquivo "CombinedShapeLightSharedHidden.hlsl" deve estar na mesma página que o arquivo "HideInShadow.shader" senão o shader não vai funcionar.

## Dependências

* Unity 2021.3.11f1 (LTS) com URP (Universal Render Pipeline) instalado
* Testado com URP versão 12.1.7
* O player na cena exemplo utiliza o ("novo") Input System "1.4.3".

## Referências

* Apesar de não conseguir fazer rodar na Unity 2021.3.* , aprendi muito com ![esse vídeo](https://www.youtube.com/watch?v=XWMPEE8O05c) e código fonte disponibilizado nele. 

* Foi com nessa pergunta do ![StackOverflow](https://stackoverflow.com/questions/65696260/is-there-a-way-to-hide-a-player-who-is-in-the-shadow-in-unity-2d-light-system/67780057#67780057) que eu descobri como fazer o shader.

## Conclusão

Espero ter ajudado! Qualquer dúvida, pode entrar em contato comigo no servidor do discord da ctrl + alt!


