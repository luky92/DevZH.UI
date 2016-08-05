﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevZH.UI.Interop;

namespace DevZH.UI
{
    public class Entry : EntryBase
    {
        public Entry()
        {
            ControlHandle = NativeMethods.NewEntry();
            InitializeEvents();
        }
    }

    public class PasswordEntry : EntryBase
    {
        public PasswordEntry()
        {
            ControlHandle = NativeMethods.NewPasswordEntry();
            InitializeEvents();
        }
    }

    public class SearchEntry : EntryBase
    {
        public SearchEntry()
        {
            ControlHandle = NativeMethods.NewSearchEntry();
            InitializeEvents();
        }
    }
}