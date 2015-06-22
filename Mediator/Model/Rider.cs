using System;
using System.Collections.Generic;

namespace Mediator.Model
{
    public class Rider : Model
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public IEnumerable<Race> Races { get; set; }
    }
}