using QualityExperienceUI.Components;
using QualityExperienceUI.Data.Services;
using QualityExperienceUI.Data.Services.CRUD;
using QualityExperienceUI.Data.Validators;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


// Localization ADD by me
builder.Services.AddLocalization();
builder.Services.AddControllers();

// AntDesign ADD by me
builder.Services.AddAntDesign();

// Refit ADD by me
builder.Services.AddRefitClient<IApiEndpoints>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://localhost:7050"));
;

// Middleware ADD by me
builder.Services.AddScoped<ApiMiddleware>();

// Inizialices CRUDs ADD by me
builder.Services.AddScoped<IClientsCRUD, ClientsCRUD>();
builder.Services.AddScoped<IContextFliedsCRUD, ContextFieldsCRUD>();
builder.Services.AddScoped<IGroupsCRUD, GroupsCRUD>();
builder.Services.AddScoped<IIndicatorsCRUD, IndicatorsCRUD>();
builder.Services.AddScoped<IQuestionsCRUD, QuestionsCRUD>();
builder.Services.AddScoped<IServicesCRUD, ServicesCRUD>();
builder.Services.AddScoped<ITemplatesCRUD, TemplatesCRUD>();



var app = builder.Build();


// Localization ADD by me
string[] supportedCultures = ["en-US", "es-CL"];
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

//Controllers for languaje ADD by me
app.MapControllers();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
