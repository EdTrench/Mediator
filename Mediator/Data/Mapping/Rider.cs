using FluentNHibernate.Mapping;

namespace Mediator.Data.Mapping
{
    class Rider : ClassMap<Model.Rider>
    {
        public Rider()
        {
            Table("rider.Riders");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Name);
            Map(x => x.DateOfBirth);
        }
    }
}