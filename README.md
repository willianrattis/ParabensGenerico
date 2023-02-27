# API de Felicitações de Aniversário

Essa API permite enviar felicitações de aniversário personalizadas para seus amigos. Você pode escolher o nível de amizade da pessoa e a mensagem será adaptada de acordo com isso. Além disso, a API oferece um endpoint para obter uma lista dos níveis de amizade disponíveis.

# Endpoints

## GET /parabens
Envia felicitações de aniversário para uma pessoa. Recebe como entrada dois parâmetros: "nome" (string) e "nivelDeAmizade" (string), que deve ser um dos níveis de amizade disponíveis.

## GET /niveis-de-amizade
Obtém uma lista dos níveis de amizade disponíveis. Retorna um array de strings.