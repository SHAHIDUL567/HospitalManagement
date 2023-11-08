﻿namespace HospitalManagement.Shared;

public interface IVm<T> where T : IEquatable<T>
{
    T Id { get; set; }
}
public interface IVm : IVm<int> { }
