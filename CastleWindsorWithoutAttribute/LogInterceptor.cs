﻿using System;
using Castle.DynamicProxy;

namespace CastleWindsorWithoutAttribute
{
        public class LogInterceptor : IInterceptor
        {
            public void Intercept(IInvocation invocation)
            {
                Console.WriteLine("{0}:拦截{1}方法{2}前,", DateTime.Now.ToString("O"), invocation.InvocationTarget.GetType().BaseType, invocation.Method.Name);
                invocation.Proceed();
                Console.WriteLine("{0}:拦截{1}方法{2}后,", DateTime.Now.ToString("O"), invocation.InvocationTarget.GetType().BaseType, invocation.Method.Name);
            }
        }
}
