using EFTemplateCore.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace EFTemplateCore.ModelMapper
{
    public static class MapperExtension
    {
        public static DTO ToDto<ENTITY, DTO>(this ENTITY entity) where ENTITY : IEntity { return MapHelper<ENTITY, DTO>.Convert(entity); }
        public static List<DTO> ToDtoList<ENTITY, DTO>(this IQueryable<ENTITY> source) { return MapHelper<ENTITY, DTO>.Convert(source); }
        public static ENTITY ToEntity<DTO, ENTITY>(this DTO view) where DTO : IDto { return MapHelper<DTO, ENTITY>.Convert(view); }
        public static List<ENTITY> ToEntityList<DTO, ENTITY>(this IQueryable<DTO> source) { return MapHelper<DTO, ENTITY>.Convert(source); }
    }
}