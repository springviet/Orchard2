using Orchard.DisplayManagement.Descriptors;

namespace Orchard.DisplayManagement
{
    /// <summary>
    /// An implementation of this interface is called whenever a shape template
    /// is seeked. it can be used to provide custom dynamic templates, for instance to override
    /// any view engine based ones.
    /// </summary>
    public interface IShapeBindingResolver
    {
        bool TryGetDescriptorBinding(string shapeType, out ShapeBinding shapeBinding);
    }
}