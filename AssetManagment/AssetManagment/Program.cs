using AssetManagment.Services;
using DataAccess.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Adding cors to avoid localhost call
// angular run in localhost and API run in localhost. since it will not allowed to call localhost again. So need to allow cors
builder.Services.AddCors(
    option =>
    {
        option.AddDefaultPolicy(
            policy =>
            {
                policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            });
    });


builder.Services.AddSingleton<IDataAccessServices, DataAccessServices>();
builder.Services.AddSingleton<IUserServices,  UserServices>();
builder.Services.AddSingleton<IRolesServices, RolesServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//use cors here
app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
