﻿namespace GenericInterfaceApp.Interfaces
{
    internal interface ISeries<T>
    {
        T GetNext();
        void Reset();
        void SetStart(T v);
    }
}
