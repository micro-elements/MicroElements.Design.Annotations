namespace MicroElements.Design.Annotations
{
    using System;

    /// <summary>
    /// Describes model conventions.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Struct)]
    public class ModelAttribute : Attribute
    {
        /// <summary>
        /// Model convention.
        /// </summary>
        public ModelConvention Convention { get; set; }
    }

    /// <summary>
    /// Model convention.
    /// </summary>
    public enum ModelConvention
    {
        /// <summary>
        /// Domain model is used in domain logic.
        /// <para>DomainModel must protect internal invariants.</para>
        /// <para>Usually immutable.</para>
        /// </summary>
        DomainModel,

        /// <summary>
        /// DTO is used for data transfer.
        /// <para>DTO should be serializable.</para>
        /// <para>DTO can be writable.</para>
        /// </summary>
        DTO,

        /// <summary>
        /// ApiContract is a model for external clients.
        /// <para>Is a special case of DTO.</para>
        /// <para>Should be versioned.</para>
        /// </summary>
        ApiContract,

        /// <summary>
        /// StorageModel is a DTO for data access layer.
        /// </summary>
        StorageModel,

        /// <summary>
        /// DDD value object.
        /// </summary>
        ValueObject,

        /// <summary>
        /// CQRS Command.
        /// </summary>
        Command,

        /// <summary>
        /// CQRS Query.
        /// </summary>
        Query
    }

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
