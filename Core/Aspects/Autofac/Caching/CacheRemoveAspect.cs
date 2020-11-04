using Core.CrossCuttingConserns.Caching;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Castle.DynamicProxy;

namespace Core.Aspects.Autofac.Caching
{
    public class CacheRemoveAspect:MethodInterception
    {
        private string _pattern;
        private ICacheManager _cacgeManager;

        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacgeManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();

        }
        protected override void OnSuccess(IInvocation invocation)
        {
            //ekleme başarılı oldugunda cache den silinir
            _cacgeManager.RemoveByPattern(_pattern);
        }
    }
}
