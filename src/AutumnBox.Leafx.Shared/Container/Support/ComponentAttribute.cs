﻿/*

* ==============================================================================
*
* Filename: ComponentAttribute
* Description: 
*
* Version: 1.0
* Created: 2020/3/30 16:14:05
* Compiler: Visual Studio 2019
*
* Author: zsh2401
*
* ==============================================================================
*/
using System;

namespace AutumnBox.Leafx.Container.Support
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = false)]
    public sealed class ComponentAttribute : Attribute
    {
        public bool SingletonMode { get; set; } = true;
        public string Id { get; set; } = null;
        public Type Type { get; set; } = null;
    }
}
