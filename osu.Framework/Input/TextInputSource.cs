﻿// Copyright (c) 2007-2016 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using System;

namespace osu.Framework.Input
{
    /// <summary>
    /// A source from which we can retrieve user text input.
    /// Generally hides a native implementation from the game framework.
    /// </summary>
    public interface TextInputSource
    {
        bool ImeActive { get; }

        string GetPendingText();

        void Deactivate(object sender);

        void Activate(object sender);

        event Action<string> OnNewImeComposition;
        event Action<string> OnNewImeResult;
    }
}
