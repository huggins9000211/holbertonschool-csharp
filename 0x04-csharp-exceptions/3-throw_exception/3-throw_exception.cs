using System;


class Except
{
    public static void Throw()
    {
        throw new System.InvalidOperationException("Logfile cannot be read-only");
    }
}
