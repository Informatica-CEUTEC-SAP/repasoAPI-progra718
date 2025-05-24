#region Step 1: Configuration Setup

using repasoAPI.Services;

var builder = WebApplication.CreateBuilder(args);
#endregion Step 1: Configuration Setup
    
#region Step2: Service Registration
#region Step2.1: Add services to the DI container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);
});
// Scoped: Se crea una nueva instancia por cada solicitud HTTP.
// Transient: Se crea una nueva instancia cada vez que se solicita.
// Singleton: Se crea una única instancia para toda la aplicación.

builder.Services.AddScoped<IEstudianteService, EstudianteService>();

#endregion Step2.1: Add services to the DI container.
    
#region Step2.2: Add database context

#endregion Step2.2: Add database context
#endregion Step2: Service Registration
    
#region Step3: Build the application
var app = builder.Build();
#endregion Step3: Build the application

#region Step4: Middleware Pipeline Configuration
app.UseHttpsRedirection();

app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
#endregion Step4: Middleware Pipeline Configuration

#region Step5: Start the Application
app.Run();
#endregion Step5: Start the Application