﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wwssi.Bluetooth.Events
{
    public class DeviceRemovedEventArgs
    {
        public Schema.WatcherDevice Device { get; set; }
    }
}
