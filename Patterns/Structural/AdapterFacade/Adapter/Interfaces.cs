﻿// Copyright Information
// =============================
// StructuralPatterns - Interfaces.cs
// All samples copyright Philip Japikse 
// http://www.skimedic.com 20/06/2017
// See License.txt for more information
// =============================
namespace StructuralPatterns.AdapterFacade.Adapter
{
    public interface ICharacter
    {
        int Chase();

        int Flee();

        int Attack();
    }

    public interface IFlyingSquirrel
    {
        int Fly();

        int DropAcorns();
    }

    public interface IMoose
    {
        int Run();

        int Charge();
    }

    public interface IBadGuy
    {
        int Drive();

        int Shoot();
    }
}