﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILinkedList.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures.LinkedList_UnOrdered_
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// linked list Interface
    /// </summary>
    /// <typeparam name="T">any parameter </typeparam>
    public interface ILinkedList<T>
    {
        /// <summary>
        /// Adds the specified word.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <returns>returns true or false</returns>
        bool Add(T word);

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        bool IsEmpty();

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns>returns size</returns>
        long Size();

        /// <summary>
        /// Deletes the specified word to search.
        /// </summary>
        /// <param name="wordToSearch">The word to search.</param>
        /// <returns>returns true or false</returns>
        bool Delete(string wordToSearch);

        /// <summary>
        /// Inserts the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="pos">The position.</param>
        /// <returns>returns true or false </returns>
        bool Insert(T data, long pos);

        /// <summary>
        /// Prints this instance.
        /// </summary>
        void Print();

        /// <summary>
        /// Determines whether this instance contains the object.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified word]; otherwise, <c>false</c>.
        /// </returns>
        bool Contains(T word);
    }
}