using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monbsoft.SimpleMC.SharedKernel
{
    public abstract class BaseEntity
    {

        public Guid Id { get; protected set; }

        public static bool operator ==(BaseEntity a, BaseEntity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, b) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(BaseEntity a, BaseEntity b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            var other = obj as BaseEntity;

            if (ReferenceEquals(other, null))
                return false;

            if (ReferenceEquals(other, this))
                return true;


            return other.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
