using QualityExperienceUI.Components;
using QualityExperienceUI.Data.Services;
using QualityExperienceUI.Data.Services.CRUD;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

 
// Localization ADD
builder.Services.AddLocalization();
builder.Services.AddControllers();

//Detailed errors ADD
builder.Services.AddServerSideBlazor()
    .AddCircuitOptions(options => { options.DetailedErrors = true; });

// AntDesign ADD
builder.Services.AddAntDesign();

// Refit ADD
builder.Services.AddRefitClient<IApiMethods>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://localhost:7050"));
;
// Middleware
builder.Services.AddScoped<ApiMiddleware>();
// Inizialices CRUDs 
builder.Services.AddScoped<IServiceCRUD, ServicesCRUD>();
builder.Services.AddScoped<IContextFieldCRUD, ContextFieldCRUD>();
builder.Services.AddScoped<IQuestionsCRUD, QuestionsCRUD>();
builder.Services.AddScoped<IGroupsCRUD, GroupsCRUD>();


var app = builder.Build();

// Localization ADD
string[] supportedCultures = ["en-US","es-CL"];
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

//Controllers for languaje ADD
app.MapControllers();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
