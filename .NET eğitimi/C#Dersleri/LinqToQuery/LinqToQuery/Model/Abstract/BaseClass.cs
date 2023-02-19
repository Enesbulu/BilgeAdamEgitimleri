using System;
using System.ComponentModel.DataAnnotations;

namespace LinqToQuery.Model.Abstract
{
    public enum StatusType { Active = 1, Passive }

    internal abstract class BaseClass<T>
    {
        [Key]
        public T Id { get; set; }

        public DateTime CreatDate { get; set; } = DateTime.Now;

        public DateTime? UpdateDate { get; set; }

        public StatusType Status { get; set; }

        public DateTime? DeleteDate { get; set; }

    }
}
