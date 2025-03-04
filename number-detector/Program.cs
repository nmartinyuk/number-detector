var app = WebApplication.CreateBuilder().Build();
app.Map("", async context => await context.Response.SendFileAsync("wwwroot/index.html"));
app.Run();