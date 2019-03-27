// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Foundation Medicine Inc." file="App.cs">
// //
// // Copyright Notice!
// // This document is protected under the trade secret and copyright
// // laws as the property of Foundation Medicine, Inc.
// // Copying, reproduction or distribution should be limited and only to
// // personnel with a “need to know” to do their job.
// // Any disclosure of this document to third parties is strictly prohibited.
// //
// // © 2019 Foundation Medicine Inc.
// // All rights reserved worldwide.
// // </copyright>
// // <summary>
// //
// // </summary>
// //
// // --------------------------------------------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
#pragma warning disable 1998

namespace LifecycleTesting
{
    public class App: IApp
    {
        private readonly IGetGuidScoped _guidScoped;
        private readonly IGetGuidSingleton _guidSingleton;

        public App(IGetGuidScoped guidScoped, IGetGuidSingleton guidSingleton)
        {
            _guidScoped = guidScoped;
            _guidSingleton = guidSingleton;
        }

        public async Task Run()
        {
            Console.WriteLine($"Scoped: {_guidScoped.Get()}");
            Console.WriteLine($"Singleton: {_guidSingleton.Get()}");
        }
    }
}