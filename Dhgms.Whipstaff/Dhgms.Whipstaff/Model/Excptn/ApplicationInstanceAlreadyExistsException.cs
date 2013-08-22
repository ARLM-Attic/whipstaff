﻿namespace Dhgms.Whipstaff.Model.Excptn
{
    using System;
    using System.Runtime.Serialization;

    using Dhgms.Whipstaff.Model.SingleInstance;

    /// <summary>
    /// The exception which is thrown when trying to initialize a second application instance, and the <see cref="SingleInstanceManager"/>
    /// is set to <see cref="TerminationOption.Throw"/>.
    /// </summary>
    [Serializable]
    public sealed class ApplicationInstanceAlreadyExistsException : Exception
    {
        internal ApplicationInstanceAlreadyExistsException()
            : base("Application instance already exists")
        { }

        private ApplicationInstanceAlreadyExistsException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
    }
}
