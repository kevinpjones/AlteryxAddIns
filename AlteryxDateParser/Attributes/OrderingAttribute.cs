namespace JDunkerley.Alteryx.Attributes
{
    using System;

    /// <summary>
    /// Order Field For a Connection
    /// </summary>
    /// <seealso cref="System.Attribute" />
    public class OrderingAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderingAttribute"/> class.
        /// </summary>
        /// <param name="order">The order.</param>
        public OrderingAttribute(int order)
        {
            this.Order = order;
        }

        /// <summary>
        /// Gets the order.
        /// </summary>
        public int Order { get; }
    }
}