using WebApi.Services.CommentService;
using WebApi.Services.PostServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<ICommentService, CommentService>();
//builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

//app.MapControllers();
app.UseRouting();
app.MapControllerRoute(name: "default", pattern: "{controller}/{action=Index}/{id?}");

app.Run();
