namespace MicroElements.Design.Annotations
{
    using System;

    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Struct)]
    public class ModelAttribute : Attribute
    {
        public ModelUsage ModelUsage { get; set; }
    }

    public enum ModelUsage
    {
        DomainModel,
        DTO,
        StorageModel,
        ValueObject
    }

    public class Conventions
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
        Custom
    }
}
