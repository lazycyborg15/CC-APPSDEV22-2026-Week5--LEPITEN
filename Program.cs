var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();




app.UseSwagger();
app.UseSwaggerUI();


//Optional: remove HTTPS redirect when using HTTP only
//app.UseHttpsRedirection();


app.UseAuthorization();


app.MapControllers();

//optional: redirect root to swagger
app.MapGet("/", () => Results.Redirect("/swagger"));


app.Run();


