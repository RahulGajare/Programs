// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures.LinkedList_Ordered_
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    public interface LinkedList
    {

        /// <summary>
        /// Adds the specified word.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <returns></returns>
        bool Add(int number);

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
        /// <returns></returns>
        long Size();

        /// <summary>
        /// Deletes the specified position.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <returns></returns>
        bool Delete(int numberToSearch);

        /// <summary>
        /// Inserts the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="pos">The position.</param>
        /// <returns></returns>
        bool Insert(int data, long pos);

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
        bool Contains(int word);


    }
}
