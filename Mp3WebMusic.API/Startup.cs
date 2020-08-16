using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mp3WebMusic.API.DbContext;
using Mp3WebMusic.BAL.Banner;
using Mp3WebMusic.BAL.INTERFACE.Banner;
using Mp3WebMusic.BAL.INTERFACE.Songs;
using Mp3WebMusic.BAL.INTERFACE.Topics;
using Mp3WebMusic.BAL.INTERFACE.Type;
using Mp3WebMusic.BAL.Singers;
using Mp3WebMusic.BAL.Songs;
using Mp3WebMusic.BAL.Topics;
using Mp3WebMusic.BAL.Type;
using Mp3WebMusic.DAL.Banner;
using Mp3WebMusic.DAL.INTERFACE;
using Mp3WebMusic.DAL.INTERFACE.Banner;
using Mp3WebMusic.DAL.INTERFACE.Singers;
using Mp3WebMusic.DAL.INTERFACE.Songs;
using Mp3WebMusic.DAL.Singers;
using Mp3WebMusic.DAL.Songs;
using Mp3WebMusic.DAL.Topics;
using Mp3WebMusic.DAL.Type;
using Mp3WebMusic.DOMAIN;

namespace Mp3WebMusic.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        //kkkkk
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Common.ConnectionString));

            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
            services.AddTransient<ITypeRepository, TypeRepository>();
            services.AddTransient<ITypeService, TypeService>();
            services.AddTransient<ISongRepository, SongRepository>();
            services.AddTransient<ISongService, SongService>();
            services.AddTransient<IAuthorRepository, AuthorRepository>();
            services.AddTransient<IAuthorService, AuthorService>();
            services.AddTransient<ITopicRepository, TopicRepository>();
            services.AddTransient<ITopicService, TopicService>();
            services.AddTransient<ISingerRepository, SingerRepository>();
            services.AddTransient<ISingerService, SingerService>();
            services.AddTransient<IBannerRepository, BannerRepository>();
            services.AddTransient<IBannerService, BannerService>();
            services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mp3Web");
            });
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
