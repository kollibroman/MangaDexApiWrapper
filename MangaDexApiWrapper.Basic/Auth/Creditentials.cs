using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MangaDexApiWrapper.Basic.Auth
{
    public class Creditentials
    {
        public Agent Agent { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}