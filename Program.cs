using Microsoft.EntityFrameworkCore;
using PokemonProject;
using PokemonProject.Interface.Repository;
using PokemonProject.Interface.Service;
using PokemonProject.Repository;
using PokemonProject.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddTransient<Seed>();

builder.Services.AddScoped<IPokemonRepository, PokemonRepository>();
builder.Services.AddScoped<ITrainerRepository, TrainerRepository>();
builder.Services.AddScoped<IStatRepository, StatRepository>();
builder.Services.AddScoped<ITypeRepository, TypeRepository>();
builder.Services.AddScoped<IPokemonStatRelationRepository, PokemonStatRelationRepository>();
builder.Services.AddScoped<IPokemonTypeRelationRepository, PokemonTypeRelationRepository>();
builder.Services.AddScoped<IPokemonTrainerRelationRepository, PokemonTrainerRelationRepository>();

builder.Services.AddScoped<IPokemonService, PokemonService>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
/*builder.Services.AddScoped<IStatService, StatService>();
builder.Services.AddScoped<ITypeService, TypeService>();
builder.Services.AddScoped<ITrainerService, TrainerService>();*/

builder.Services.AddDbContext<DataContext>(options =>
     {
         options.UseNpgsql(builder.Configuration.GetConnectionString("WebApiDatabase"));

     }
);
var app = builder.Build();
if(args.Length==1 && args[0].ToLower()=="seeddata")
{
    SeedData(app);
}
void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();
    using(var scope = scopedFactory.CreateScope())
    {
        var service=scope.ServiceProvider.GetService<Seed>();
        service.SeedDataContext();
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
