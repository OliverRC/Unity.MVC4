﻿using Microsoft.Web.Infrastructure.DynamicModuleHelper;

namespace Unity.Mvc4
{
    public class PreApplicationStartCode
    {
        private static bool _isStarting;

        public static void PreStart()
        {
            if (!_isStarting)
            {
                _isStarting = true;

                DynamicModuleUtility.RegisterModule(typeof(RequestLifetimeHttpModule));
            }
        }
    }
}