using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFTemplateCore
{
    public static class MapHelper<TSource, TTarget>
    {
        public static void CreateMap()
        {
            try
            {
                Mapper.Initialize(cfg => cfg.CreateMap<TSource, TTarget>().ReverseMap());
            }
            catch(InvalidOperationException ex)
            {
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
            foreach (TSource source in sourceList)
            {
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
