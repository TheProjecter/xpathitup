﻿/*
Copyright (C) 2010  Torgeir Helgevold

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XPathItUp
{
    internal class TextElement: Base, ITextElement
    {
        internal static ITextElement Create(string text, List<string> expressionParts)
        {
            return new TextElement(text, expressionParts);
        }

        private TextElement(string text, List<string> expressionParts)
        {
            string exp = string.Format("[text()='{0}']", text);
            this.ExpressionParts = expressionParts;
            expressionParts.Add(exp);
        }
    }
}