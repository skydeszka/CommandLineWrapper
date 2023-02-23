﻿using System.CommandLine;

namespace CommandLineWrapper;

/// <summary>
/// Wrapper for the <see cref="Command"/> class.
/// </summary>
public sealed class CommandWrapper
{
    private readonly string _name;
    private string? _description;

    private List<Argument>? _arguments;
    private List<Option>? _options;
    private List<Command>? _subcommands;

    /// <summary>
    /// Represents all of the arguments for the command.
    /// </summary>
    public IReadOnlyList<Argument> Arguments => _arguments is not null ? _arguments : Array.Empty<Argument>();
    /// <summary>
    /// Represents all of the options for the command, including global options that have been applied to any of the command's ancestors.
    /// </summary>
    public IReadOnlyList<Option> Options => _options is not null ? _options : Array.Empty<Option>();
    /// <summary>
    /// Represents all of the subcommands for the command.
    /// </summary>
    public IReadOnlyList<Command> Subcommands => _subcommands is not null ? _subcommands : Array.Empty<Command>();

    private CommandWrapper(string name)
    {
        _name = name;
    }

    /// <summary>
    /// Creates a <see langword="new"/> instance of <see cref="CommandWrapper"/> with the given <paramref name="name"/>
    /// that can be later converted into <see cref="Command"/>.
    /// </summary>
    /// <param name="name">Name of the command.</param>
    /// <returns>A <see langword="new"/> instance <see cref="CommandWrapper"/> with the given <paramref name="name"/>.</returns>
    public static CommandWrapper CreateCommand(string name)
    {
        return new(name);
    }
    /// <summary>
    /// Sets the description for the command.
    /// </summary>
    /// <param name="description">The text to set as description</param>
    /// <returns>The <see cref="CommandWrapper"/> with its description set.</returns>
    public CommandWrapper SetDescription(string description)
    {
        _description = description;
        return this;
    }

    /// <summary>
    /// Adds an <see cref="Argument"/> to the command.
    /// </summary>
    /// <param name="argument">The argument to add to the command.</param>
    /// <returns>The <see cref="CommandWrapper"/> with the argument added.</returns>
    public CommandWrapper AddArgument(Argument argument)
    {
        (_arguments ??= new()).Add(argument);
        return this;
    }

    /// <summary>
    /// Adds an <see cref="Option"/> to the command.
    /// </summary>
    /// <param name="option">The option to add to the command.</param>
    /// <returns>The <see cref="CommandWrapper"/> with the <paramref name="option"/> added.</returns>
    public CommandWrapper AddOption(Option option)
    {
        (_options ??= new()).Add(option);
        return this;
    }

    /// <summary>
    /// Adds a subcommand to the command.
    /// </summary>
    /// <remarks>Commands can be nested to an arbitrary depth.</remarks>
    /// <param name="subcommand">The subcommand to add to the command.</param>
    /// <returns>The <see cref="CommandWrapper"/> with the <paramref name="subcommand"/> added.</returns>
    public CommandWrapper AddCommand(Command subcommand)
    {
        (_subcommands ??= new()).Add(subcommand);
        return this;
    }
}
