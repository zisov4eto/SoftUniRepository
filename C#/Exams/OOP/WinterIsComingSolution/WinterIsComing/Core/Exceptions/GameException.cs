﻿namespace WinterIsComing.Core.Exceptions
{
    using System;

    public class GameException : Exception
    {
        public GameException(string message)
            : base(message)
        {
        }
    }
}
