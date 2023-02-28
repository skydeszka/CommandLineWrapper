﻿using System.CommandLine;
using System.CommandLine.Binding;
using System.CommandLine.Invocation;

namespace CommandLineWrapper.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods responsible for setting the properties of a <see cref="RootCommand"/>.
/// </summary>
public partial interface IRootCommandCanSetProperties : ICommandBaseCanSetProperties
{
    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler(Action{InvocationContext})"/>
    new IRootCommandCanSetProperties SetHandler(Action<InvocationContext> handle);

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler(Action)"/>
    new IRootCommandCanSetProperties SetHandler(Action handle);

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler{T}(Action{T}, IValueDescriptor{T})"/>
    new IRootCommandCanSetProperties SetHandler<T>(Action<T> handle, IValueDescriptor<T> symbol);

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler{T1, T2}(Action{T1, T2}, IValueDescriptor{T1}, IValueDescriptor{T2})"/>
    new IRootCommandCanSetProperties SetHandler<T1, T2>(Action<T1, T2> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2);

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler{T1, T2, T3}(Action{T1, T2, T3}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3})"/>
    new IRootCommandCanSetProperties SetHandler<T1, T2, T3>(Action<T1, T2, T3> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3);

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler{T1, T2, T3, T4}(Action{T1, T2, T3, T4}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4})"/>
    new IRootCommandCanSetProperties SetHandler<T1, T2, T3, T4>(Action<T1, T2, T3, T4> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4);

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler{T1, T2, T3, T4, T5}(Action{T1, T2, T3, T4, T5}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5})"/>
    new IRootCommandCanSetProperties SetHandler<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5);

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler{T1, T2, T3, T4, T5, T6}(Action{T1, T2, T3, T4, T5, T6}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6})"/>
    new IRootCommandCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6);

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler{T1, T2, T3, T4, T5, T6, T7}(Action{T1, T2, T3, T4, T5, T6, T7}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6}, IValueDescriptor{T7})"/>
    new IRootCommandCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6,
        IValueDescriptor<T7> symbol7);

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler{T1, T2, T3, T4, T5, T6, T7, T8}(Action{T1, T2, T3, T4, T5, T6, T7, T8}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6}, IValueDescriptor{T7}, IValueDescriptor{T8})"/>
    new IRootCommandCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6,
        IValueDescriptor<T7> symbol7,
        IValueDescriptor<T8> symbol8);
}
