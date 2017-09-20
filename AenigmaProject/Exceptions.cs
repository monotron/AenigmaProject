﻿using System;

namespace AenigmaProject
{
    /// <summary>
    /// Exception thrown if a level to be loaded is not found.
    /// </summary>
    public class LevelNotFoundException : Exception
    {
        public LevelNotFoundException(string message) : base(message)
        {
            
        }
    }
    
    /// <summary>
    /// Exception thrown if a level fails to load.
    /// </summary>
    public class LevelLoadException : Exception
    {
        public LevelLoadException(string message) : base(message)
        {
            
        }
    }

    /// <summary>
    /// Exception thrown if a level is invalid.
    /// </summary>
    public class InvalidLevelException : Exception
    {
        public InvalidLevelException(string message) : base(message)
        {
            
        }
    }
}