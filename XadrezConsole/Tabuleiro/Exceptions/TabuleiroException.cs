﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro.Exceptions
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg) { }
    }
}
