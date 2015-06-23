using System;
using System.Collections.Generic;

namespace Mediator.Model
{
    public class Rider : Model
    {
        public virtual string Name { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual IEnumerable<Race> Races { get; set; }
    }
}