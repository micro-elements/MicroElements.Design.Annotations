using System;

namespace MicroElements.Design.Annotations
{
    internal class ImmutableAttribute : Attribute
    {
    }

    internal class Conventions
    {
        public bool Immutable;
        public bool Serializable;
    }

    public enum ArchitectureStyle
    {
        Chaos,
        DDD,
        CQRS,
        Hexagonal,
        Messaging,
        Custom
    }

    public abstract class DesignConventions
    {
        public abstract ArchitectureStyle ArchitectureStyle { get; }
    }

    [Model(Convention = ModelConvention.DTO)]
    internal class ModelExample
    {
        public string Name { get; set; }
    }
}
