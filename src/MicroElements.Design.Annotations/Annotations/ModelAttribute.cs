// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MicroElements.Design.Annotations
{
    using System;

    /// <summary>
    /// Describes model conventions.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface, AllowMultiple = true)]
    public class ModelAttribute : Attribute
    {
        /// <summary>
        /// Model convention.
        /// </summary>
        public ModelConvention Convention { get; set; }
    }
}
