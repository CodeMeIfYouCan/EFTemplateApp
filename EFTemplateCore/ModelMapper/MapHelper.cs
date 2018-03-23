using AutoMapper;
using EFTemplateCore.Logging;
using EFTemplateCore.ServiceLocator;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace EFTemplateCore.ModelMapper
{
    public static class MapHelper<TSource, TTarget>
    {
        /// <summary>
        /// AutoMapper takes InvalidOperationException exception when initilizes again with the same type name
        /// One way is to initilize the types on startup of the application or keep the mappings of the types.
        /// todo:emrahdi there is no thread safe hashset.ConcurrentDictionary must be used
        /// </summary>
        static ConcurrentDictionary<string, string> MapDictionary = new ConcurrentDictionary<string, string>();
        public static void CreateMap()
        {
            try {
                string typeName = string.Concat(typeof(TSource).Name, "-", typeof(TTarget).Name);
                if (!MapDictionary.ContainsKey(typeName)) {
                    Mapper.Initialize(cfg => cfg.CreateMap<TSource, TTarget>());
                    MapDictionary.TryAdd(typeName, typeName);
                }
            }
            catch (InvalidOperationException ex) {
                Services.Create<ILog>().LogFormat("Exeption in MapHelper-CreateMap:{0}", LogLevel.Warning, ex);
            }
        }

        public static TTarget Convert(TSource source)
        {
            CreateMap();
            return Mapper.Map<TSource, TTarget>(source);
        }

        public static List<TTarget> Convert(List<TSource> sourceList)
        {
            CreateMap();
            List<TTarget> viewList = new List<TTarget>();
            foreach (TSource source in sourceList) {
                viewList.Add(Mapper.Map<TSource, TTarget>(source));
            }
            return viewList;
        }

        public static List<TTarget> Convert(IQueryable<TSource> sourceList)
        {
            return Convert(sourceList.ToList());
        }
    }
}
