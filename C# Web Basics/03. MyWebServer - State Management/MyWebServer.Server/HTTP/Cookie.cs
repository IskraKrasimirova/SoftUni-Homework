﻿using MyWebServer.Server.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebServer.Server.HTTP
{
    public class Cookie
    {
        public string Name { get; init; }
        public string Value { get; init; }

        public Cookie(string name, string value)
        {
            Guard.AgainstNull(name, nameof(name));  
            Guard.AgainstNull(value, nameof(value));

            this.Name = name;
            this.Value = value;
        }

        public override string ToString()
        => $"{this.Name}={this.Value}";
    }
}
