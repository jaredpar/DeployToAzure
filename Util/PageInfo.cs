using System;
using System.Runtime.InteropServices;

namespace Util
{
    public class PageInfo
    {
        public string Greeting { get; set; } = "Util Hello World Again On " + RuntimeInformation.OSDescription;
    }
}
