// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Customer.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;

    /// <summary>
    /// Implementation example of reflection
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        public Customer()
        {
            this.ID = this.ID;
            this.Name = this.Name;
        }
        
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
      
        /// <summary>
        /// Reflections this instance.
        /// </summary>
        public void Reflection()
        {
            ////getting all metadata using static method
            Type type = Type.GetType("Implementations.Customer");
            ////printing fully qualified name
            Console.WriteLine("Full Name: " + type.FullName);
            ////printing name of class
            Console.WriteLine("Name: " + type.Name);
            ////printing namespace
            Console.WriteLine("Namespace: " + type.Namespace);
            Console.WriteLine();
            ////getting all properties
            Console.WriteLine("Properties: ");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

            Console.WriteLine();
            ////getting all methods
            Console.WriteLine("Methods: ");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }

            Console.WriteLine();
            ////getting all constuctors
            Console.WriteLine("Constructors: ");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
