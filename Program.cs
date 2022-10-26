/*
ARELY MARTINEZ 
OCT 25, 2022 9:30PM
REVERSE IT END POINT 
THIS PROGRAM WILL MAKE IT SO THAT THE USER 
CAN ENTER A GROUP OF CHARACTER. AND ON POSTMAN 
IT WILL REPSOND WITH THE USERS ORIGINAL INPUT 
AND A NEW OUPUT OF THIER INPUT BUT REVERESED.

PEER REVIEW: NAME -- REVIEW 
*/
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
