// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IStore.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// store interface
    /// </summary>
    public interface IStore
    {
        /// <summary>
        /// Visits the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        void Visit(IVisitor visitor);
    }
}
