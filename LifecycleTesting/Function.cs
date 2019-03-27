using System;
using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Microsoft.Extensions.DependencyInjection;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace LifecycleTesting
{
    public class Function
    {
        private readonly IServiceProvider _serviceProvider;

        public Function()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IApp, App>();
            serviceCollection.AddScoped<IGetGuidScoped, GuidMaker>();
            serviceCollection.AddSingleton<IGetGuidSingleton, GuidMaker>();

            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        public async Task FunctionHandler(InputEvent input, ILambdaContext context)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                await scope.ServiceProvider.GetService<IApp>().Run();
            }
        }
    }
}
