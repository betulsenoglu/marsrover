using System;
using MarsRover.Utility.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace MarsRover.Configuration.IocContainer
{
    public sealed class ServiceCollectionManager
    {
        private readonly IServiceProvider _provider;
        private static ServiceCollectionManager _instance;
        private static object _lockObj = new object();

        public static ServiceCollectionManager CurrentInstance
        {
            get
            {
                return GetCurrentInstance();
            }
        }


        internal ServiceCollectionManager(IServiceCollection services)
        {
            _provider = services
                .BuildServiceProvider();
        }

        public static ServiceCollectionManager GetCurrentInstance()
        {
            Guard.AgainstNullArgument(_instance, nameof(_instance));
            return _instance;
        }

        public static void Initialize(IServiceCollection services)
        {
            lock (_lockObj)
            {
                if (_instance == null)
                {
                    _instance = new ServiceCollectionManager(services);
                }
            }
        }

        public T Resolve<T>()
        {
            return _provider.GetService<T>();
        }
    }
}