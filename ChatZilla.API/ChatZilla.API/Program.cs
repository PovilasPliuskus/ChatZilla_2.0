using ChatZilla.API;
using ChatZilla.User;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services
    .BuildUserDiModule(connectionString ?? throw new ArgumentNullException(nameof(connectionString)))
    .BuildApiDiModule();

// I think the Notification module is the only one using mongoDb, so this should probably go there.
// Commenting it out for now.
// builder.Services.AddScoped<MongoDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();