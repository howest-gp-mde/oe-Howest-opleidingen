using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using IdentityServer4.Models;
using IdentityServer4;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization();

builder.Services.AddIdentityServer(x => x.IssuerUri = "null")
    .AddInMemoryIdentityResources(new List<IdentityResource>
     {
     new IdentityResources.OpenId(),
     new IdentityResources.Profile()
     })
    //.AddInMemoryApiResources()
    //.AddInMemoryApiScopes()
    .AddInMemoryClients(new List<Client>
 {
 // Omitted for brevity
 new Client
 {
 ClientId = "xamarin",
 ClientName = "eShop Xamarin OpenId Client",
 AllowedGrantTypes = GrantTypes.Hybrid,
 ClientSecrets =
 {
 new Secret("secret".Sha256())
 },
 RedirectUris = { /**clientsUrl["Xamarin"]**/ "" },
 RequireConsent = false,
 RequirePkce = true,
 PostLogoutRedirectUris = { "" /*$"{clientsUrl["Xamarin"]}/Account/Redirecting"*/ },
 AllowedCorsOrigins = { "http://eshopxamarin" },
 AllowedScopes = new List<string>
 {
 IdentityServerConstants.StandardScopes.OpenId,
 IdentityServerConstants.StandardScopes.Profile,
 IdentityServerConstants.StandardScopes.OfflineAccess
 },
 AllowOfflineAccess = true,
 AllowAccessTokensViaBrowser = true
 } });


// Configure identity database access via EF Core.
builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseInMemoryDatabase("AppDb"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddIdentityApiEndpoints<IdentityUser>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


//app.MapIdentityApi<IdentityUser>();
app.UseIdentityServer();
app.Run();

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
        base(options)
    { }
}