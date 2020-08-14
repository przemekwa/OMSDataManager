using System.Collections.Generic;

namespace OMSDataManager
{
    public interface IModelBuilder<T>
    {
        List<T> Build();
    }
}