﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Foundation Medicine Inc." file="GuidMaker.cs">
// //
// // Copyright Notice!
// // This document is protected under the trade secret and copyright
// // laws as the property of Foundation Medicine, Inc.
// // Copying, reproduction or distribution should be limited and only to
// // personnel with a “need to know” to do their job.
// // Any disclosure of this document to third parties is strictly prohibited.
// //
// // © 2018 Foundation Medicine Inc.
// // All rights reserved worldwide.
// // </copyright>
// // <summary>
// //
// // </summary>
// //
// // --------------------------------------------------------------------------------------------------------------------

using System;

namespace LifecycleTesting
{
    public class GuidMaker : IGetGuidScoped, IGetGuidSingleton, IDisposable
    {
        private readonly Guid _guid;

        public GuidMaker()
        {
            _guid = Guid.NewGuid();
        }

        public Guid Get()
        {
            return _guid;
        }

        public void Dispose()
        {
            Console.WriteLine("Disposing");
        }
    }
}