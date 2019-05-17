﻿// <auto-generated />
using System;
using MicroService.ApiGateway.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MicroService.ApiGateway.Migrations
{
    [DbContext(typeof(ApiGatewayDbContext))]
    partial class ApiGatewayDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.AuthenticationOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AllowedScopes")
                        .HasMaxLength(200);

                    b.Property<string>("AuthenticationProviderKey")
                        .HasMaxLength(100);

                    b.Property<int>("ReRouteId");

                    b.HasKey("Id");

                    b.HasIndex("ReRouteId")
                        .IsUnique();

                    b.ToTable("AbpApiGatewayAuthOptions");
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.CacheOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ReRouteId");

                    b.Property<string>("Region")
                        .HasMaxLength(256);

                    b.Property<int>("TtlSeconds");

                    b.HasKey("Id");

                    b.HasIndex("ReRouteId")
                        .IsUnique();

                    b.ToTable("AbpApiGatewayCacheOptions");
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.DynamicReRoute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<int>("DunamicReRouteId");

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties");

                    b.Property<int?>("RateLimitRuleId");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("RateLimitRuleId");

                    b.ToTable("AbpApiGatewayDynamicReRoute");
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.GlobalConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BaseUrl")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("DownstreamScheme")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties");

                    b.Property<int?>("HttpHandlerOptionsId");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<int>("ItemId");

                    b.Property<int?>("LoadBalancerOptionsId");

                    b.Property<int?>("QoSOptionsId");

                    b.Property<int?>("RateLimitOptionsId");

                    b.Property<string>("RequestIdKey")
                        .HasMaxLength(100);

                    b.Property<int?>("ServiceDiscoveryProviderId");

                    b.HasKey("Id");

                    b.HasIndex("HttpHandlerOptionsId");

                    b.HasIndex("LoadBalancerOptionsId");

                    b.HasIndex("QoSOptionsId");

                    b.HasIndex("RateLimitOptionsId");

                    b.HasIndex("ServiceDiscoveryProviderId");

                    b.ToTable("AbpApiGatewayGlobalConfiguration");
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.Headers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .HasMaxLength(50);

                    b.Property<int>("ReRouteId");

                    b.Property<string>("Value")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("AbpApiGatewayHeaders");
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.HostAndPort", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Host");

                    b.Property<int>("Port");

                    b.Property<int>("ReRouteId");

                    b.HasKey("Id");

                    b.ToTable("AbpApiGatewayHostAndPort");
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.HttpHandlerOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AllowAutoRedirect");

                    b.Property<int>("ItemId");

                    b.Property<bool>("UseCookieContainer");

                    b.Property<bool>("UseProxy");

                    b.Property<bool>("UseTracing");

                    b.HasKey("Id");

                    b.ToTable("AbpApiGatewayHttpOptions");
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.LoadBalancerOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Expiry");

                    b.Property<int>("ItemId");

                    b.Property<string>("Key")
                        .HasMaxLength(100);

                    b.Property<string>("Type")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("AbpApiGatewayBalancerOptions");
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.QoSOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DurationOfBreak");

                    b.Property<int>("ExceptionsAllowedBeforeBreaking");

                    b.Property<int>("ItemId");

                    b.Property<int>("TimeoutValue");

                    b.HasKey("Id");

                    b.ToTable("AbpApiGatewayQoSOptions");
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.RateLimitOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientIdHeader")
                        .HasMaxLength(50);

                    b.Property<bool>("DisableRateLimitHeaders");

                    b.Property<int>("HttpStatusCode");

                    b.Property<int>("ItemId");

                    b.Property<string>("QuotaExceededMessage")
                        .HasMaxLength(256);

                    b.Property<string>("RateLimitCounterPrefix")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("AbpApiGatewayRateLimitOptions");
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.RateLimitRule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientWhitelist")
                        .HasMaxLength(1000);

                    b.Property<bool>("EnableRateLimiting");

                    b.Property<long>("Limit");

                    b.Property<string>("Period")
                        .HasMaxLength(50);

                    b.Property<double>("PeriodTimespan");

                    b.Property<int>("ReRouteId");

                    b.HasKey("Id");

                    b.HasIndex("ReRouteId")
                        .IsUnique();

                    b.ToTable("AbpApiGatewayRateLimitRule");
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.ReRoute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddClaimsToRequest")
                        .HasMaxLength(1000);

                    b.Property<string>("AddHeadersToRequest")
                        .HasMaxLength(1000);

                    b.Property<string>("AddQueriesToRequest")
                        .HasMaxLength(1000);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<bool?>("DangerousAcceptAnyServerCertificateValidator");

                    b.Property<string>("DelegatingHandlers");

                    b.Property<string>("DownstreamHeaderTransform")
                        .HasMaxLength(1000);

                    b.Property<string>("DownstreamHostAndPorts")
                        .HasMaxLength(1000);

                    b.Property<string>("DownstreamPathTemplate")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("DownstreamScheme")
                        .HasMaxLength(100);

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties");

                    b.Property<int?>("HttpHandlerOptionsId");

                    b.Property<string>("Key")
                        .HasMaxLength(100);

                    b.Property<int?>("LoadBalancerOptionsId");

                    b.Property<int?>("Priority");

                    b.Property<int?>("QoSOptionsId");

                    b.Property<int>("ReRouteId");

                    b.Property<bool?>("ReRouteIsCaseSensitive");

                    b.Property<string>("ReRouteName");

                    b.Property<string>("RequestIdKey")
                        .HasMaxLength(100);

                    b.Property<string>("RouteClaimsRequirement")
                        .HasMaxLength(1000);

                    b.Property<string>("ServiceName")
                        .HasMaxLength(100);

                    b.Property<int?>("Timeout");

                    b.Property<string>("UpstreamHeaderTransform")
                        .HasMaxLength(1000);

                    b.Property<string>("UpstreamHost")
                        .HasMaxLength(100);

                    b.Property<string>("UpstreamHttpMethod")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UpstreamPathTemplate")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("HttpHandlerOptionsId");

                    b.HasIndex("LoadBalancerOptionsId");

                    b.HasIndex("QoSOptionsId");

                    b.ToTable("AbpApiGatewayReRoute");
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.SecurityOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IPAllowedList")
                        .HasMaxLength(1000);

                    b.Property<string>("IPBlockedList")
                        .HasMaxLength(1000);

                    b.Property<int>("ReRouteId");

                    b.HasKey("Id");

                    b.HasIndex("ReRouteId")
                        .IsUnique();

                    b.ToTable("AbpApiGatewaySecurityOptions");
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.ServiceDiscoveryProvider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfigurationKey")
                        .HasMaxLength(256);

                    b.Property<string>("Host")
                        .HasMaxLength(50);

                    b.Property<int>("ItemId");

                    b.Property<string>("Namespace")
                        .HasMaxLength(128);

                    b.Property<int>("PollingInterval");

                    b.Property<int>("Port");

                    b.Property<string>("Token")
                        .HasMaxLength(256);

                    b.Property<string>("Type")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("AbpApiGatewayDiscovery");
                });

            modelBuilder.Entity("Volo.Abp.SettingManagement.Setting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(64);

                    b.Property<string>("ProviderName")
                        .HasMaxLength(64);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(2048);

                    b.HasKey("Id");

                    b.HasIndex("Name", "ProviderName", "ProviderKey");

                    b.ToTable("AbpSettings");
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.AuthenticationOptions", b =>
                {
                    b.HasOne("MicroService.ApiGateway.Entites.Ocelot.ReRoute")
                        .WithOne("AuthenticationOptions")
                        .HasForeignKey("MicroService.ApiGateway.Entites.Ocelot.AuthenticationOptions", "ReRouteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.CacheOptions", b =>
                {
                    b.HasOne("MicroService.ApiGateway.Entites.Ocelot.ReRoute")
                        .WithOne("CacheOptions")
                        .HasForeignKey("MicroService.ApiGateway.Entites.Ocelot.CacheOptions", "ReRouteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.DynamicReRoute", b =>
                {
                    b.HasOne("MicroService.ApiGateway.Entites.Ocelot.RateLimitRule", "RateLimitRule")
                        .WithMany()
                        .HasForeignKey("RateLimitRuleId");
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.GlobalConfiguration", b =>
                {
                    b.HasOne("MicroService.ApiGateway.Entites.Ocelot.HttpHandlerOptions", "HttpHandlerOptions")
                        .WithMany()
                        .HasForeignKey("HttpHandlerOptionsId");

                    b.HasOne("MicroService.ApiGateway.Entites.Ocelot.LoadBalancerOptions", "LoadBalancerOptions")
                        .WithMany()
                        .HasForeignKey("LoadBalancerOptionsId");

                    b.HasOne("MicroService.ApiGateway.Entites.Ocelot.QoSOptions", "QoSOptions")
                        .WithMany()
                        .HasForeignKey("QoSOptionsId");

                    b.HasOne("MicroService.ApiGateway.Entites.Ocelot.RateLimitOptions", "RateLimitOptions")
                        .WithMany()
                        .HasForeignKey("RateLimitOptionsId");

                    b.HasOne("MicroService.ApiGateway.Entites.Ocelot.ServiceDiscoveryProvider", "ServiceDiscoveryProvider")
                        .WithMany()
                        .HasForeignKey("ServiceDiscoveryProviderId");
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.RateLimitRule", b =>
                {
                    b.HasOne("MicroService.ApiGateway.Entites.Ocelot.ReRoute")
                        .WithOne("RateLimitOptions")
                        .HasForeignKey("MicroService.ApiGateway.Entites.Ocelot.RateLimitRule", "ReRouteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.ReRoute", b =>
                {
                    b.HasOne("MicroService.ApiGateway.Entites.Ocelot.HttpHandlerOptions", "HttpHandlerOptions")
                        .WithMany()
                        .HasForeignKey("HttpHandlerOptionsId");

                    b.HasOne("MicroService.ApiGateway.Entites.Ocelot.LoadBalancerOptions", "LoadBalancerOptions")
                        .WithMany()
                        .HasForeignKey("LoadBalancerOptionsId");

                    b.HasOne("MicroService.ApiGateway.Entites.Ocelot.QoSOptions", "QoSOptions")
                        .WithMany()
                        .HasForeignKey("QoSOptionsId");
                });

            modelBuilder.Entity("MicroService.ApiGateway.Entites.Ocelot.SecurityOptions", b =>
                {
                    b.HasOne("MicroService.ApiGateway.Entites.Ocelot.ReRoute")
                        .WithOne("SecurityOptions")
                        .HasForeignKey("MicroService.ApiGateway.Entites.Ocelot.SecurityOptions", "ReRouteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
