﻿/*
 * Copyright (C) 2012 Interactive Lab
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation 
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the 
 * 
 */

using UnityEngine;

namespace TouchScript.InputSources {
    /// <summary>
    /// Interface for objects which can remap screen coordinates.
    /// </summary>
    public interface ICoordinatesRemapper {
        /// <summary>
        /// Remaps the specified input.
        /// </summary>
        /// <param name="input">Original coordinates.</param>
        /// <returns>Changed coordinates.</returns>
        Vector2 Remap(Vector2 input);
    }
}