var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/niveis-de-amizade", () =>
{
    var niveisDeAmizade = new string[] { "amigo", "muito amigo", "conhecido", "colega", "desconhecido" };

    return Results.Ok(niveisDeAmizade);
});

app.MapGet("/parabens", (string nome, string nivelDeAmizade) =>
{
    string mensagemDeParabens = "";

    switch (nivelDeAmizade)
    {
        case "amigo":
            mensagemDeParabens = $"Feliz aniversário, {nome}! Espero que você tenha um dia maravilhoso e cheio de alegria. Parabéns, meu amigo!";
            break;
        case "muito amigo":
            mensagemDeParabens = $"Feliz aniversário, {nome}! Você é uma pessoa incrível e merece tudo de melhor nesta vida. Espero que seu dia seja tão especial quanto você. Parabéns, meu grande amigo!";
            break;
        case "conhecido":
            mensagemDeParabens = $"Feliz aniversário, {nome}! Desejo a você muita paz, saúde e felicidade nesta nova jornada. Parabéns!";
            break;
        case "colega":
            mensagemDeParabens = $"Feliz aniversário, {nome}! Que este dia seja repleto de alegria e boas surpresas. Parabéns, colega!";
            break;
        case "desconhecido":
            mensagemDeParabens = $"Feliz aniversário, {nome}! Embora eu não o conheça muito bem, desejo a você muita felicidade e realizações nesta nova idade. Parabéns!";
            break;
    }

    return Task.FromResult(new { mensagem = mensagemDeParabens });
});



app.Run();
