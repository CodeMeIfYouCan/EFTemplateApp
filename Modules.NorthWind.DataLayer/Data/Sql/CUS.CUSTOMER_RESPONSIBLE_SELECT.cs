Selectcr.*,
af.ResponsibleName,
af.UserName,
af2.UserName as BackUpUserName,
af2.ResponsibleName as BackUpResponsibleName 
from CustomerResponsible cr WITH(nolock)
inner join Customers c (nolock) on (cr.Id=c.Id) 
inner join AfiliAgent af (nolock) on  cr.ResponsibleCode=af.ResponsibleCode 
left join AfiliAgent af2 (nolock) on  cr.BackUpResponsibleCode=af2.ResponsibleCode AND af2.RecordStatus='A'
wherecr.Id={0} 
andcr.RecordStatus = 'A'
and af.RecordStatus='A'
