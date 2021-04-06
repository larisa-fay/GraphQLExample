using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
    public interface IFooBarBaz { }
    public class FooBarBazType
    : UnionType<IFooBarBaz>
    {

        
        protected override void Configure(IUnionTypeDescriptor descriptor)
        {
            descriptor.Name("FooBarBaz");
            descriptor.Type<FooType>();
            descriptor.Type<BarType>();
            descriptor.Type<BazType>();
        }
        
    }
}
