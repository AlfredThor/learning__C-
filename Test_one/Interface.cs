/*接口*/

using System;
using Mspace;

//实例
namespace Mspace
{
    interface IMyInterface
    {
        void MethodToImplement();
    }

    // class InterfaceImplementer : IMyInterface
    // {
    //     static void Main()
    //     {
    //         InterfaceImplementer iTmp = new InterfaceImplementer();
    //         iTmp.MethodToImplement();
    //     }
    //     public void MethodToImplement()
    //     {
    //         Console.WriteLine("MethodToImplement() called.");
    //     }
    // }
}

//接口继承
namespace API
{
    interface Ipsource
    {
        void parentInterfaceMethod();
    }

    interface Imysource : Ipsource
    {
        void MethodToImplement();
    }

    // class Lementer : IMyInterface
    // {
        // static void Main()
        // {
        //     Lementer itmp = new Lementer();
        //     itmp.MethodToImplement();
        //     itmp.ParentInterfaceMethod();
        // }
        // public void MethodToImplement()
        // {
        //     Console.WriteLine("MethodToImplement() called.");
        // }
        //
        // public void ParentInterfaceMethod()
        // {
        //     Console.WriteLine("ParentInterfaceMethod() called.");
        // }
    // }
}