﻿namespace TcHaxx.Snappy.CLI.Commands;

internal interface ICommandVerify
{
    Task<int> RunAndReturnExitCode(VerifyOptions options);
}
