// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MicroElements.Design.Annotations
{
    using System;

    /// <summary>
    /// Model convention.
    /// </summary>
    [Flags]
    public enum ModelConvention
    {
        /// <summary>
        /// Unknown model convention.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Domain model is used in domain logic.
        /// <para>DomainModel must protect internal invariants.</para>
        /// <para>Usually immutable.</para>
        /// </summary>
        DomainModel = 1 << 0,

        /// <summary>
        /// DTO is used for data transfer.
        /// <para>DTO should be serializable.</para>
        /// <para>DTO can be writable.</para>
        /// </summary>
        DTO = 1 << 1,

        /// <summary>
        /// ApiContract is a model for external clients.
        /// <para>Is a special case of DTO.</para>
        /// <para>Should be versioned.</para>
        /// </summary>
        ApiContract = 1 << 2,

        /// <summary>
        /// StorageModel is a DTO for data access layer.
        /// </summary>
        StorageModel = 1 << 3,

        /// <summary>
        /// DDD value object.
        /// </summary>
        ValueObject = 1 << 4,

        /// <summary>
        /// CQRS Command.
        /// </summary>
        Command = 1 << 5,

        /// <summary>
        /// CQRS Query.
        /// </summary>
        Query = 1 << 6,
    }
}
