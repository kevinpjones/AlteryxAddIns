﻿namespace JDunkerley.Alteryx
{
    using System.Collections.Generic;
    using System.Xml;

    using AlteryxRecordInfoNet;

    /// <summary>
    /// Incoming Connection Engine Interface
    /// </summary>
    public interface IInputProperty : IIncomingConnectionInterface
    {
        /// <summary>
        /// Engine Hosting Property
        /// </summary>
        INetPlugin Engine { get; set; }
    }
}