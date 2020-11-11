using System;
using System.Collections.Generic;
using System.Text;

namespace PatternAbstractFactory
{
    /// <summary>
    /// A concrete implementation of product B.
    /// </summary>
    public class ConcreteProductB2 : IProductB
    {
        /// <summary><inheritdoc/></summary>
        public string SomePropertieB { get; set; }
        /// <summary><inheritdoc/></summary>
        public string AnotherPropertieB { get; set; }
    }
}
