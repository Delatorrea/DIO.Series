using System;

namespace DIO.Series.Models
{
    public abstract class Identity
    {
        protected int Id { get; set; }
        protected DateTime Date { get; set; }
    }
}