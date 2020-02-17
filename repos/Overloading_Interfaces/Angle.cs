using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Overloading_Interfaces
{
    struct Angle : IComparable, IEnumerable
    {    
        public int degrees { get; set; }
        public int minutes { get; set; }
        public int seconds { get; set; }

        public Angle(int d, int m, int s)
        {
            degrees = d;
            minutes = m;
            seconds = s;
        }

        public override string ToString()
        {
            return String.Format("{0}  {1}  {2}", degrees, minutes, seconds);
        }

        public bool Equals(Angle other)
        {
            return degrees == other.degrees && minutes == other.minutes && seconds == other.seconds;
        }

        public override bool Equals(object obj)
        {
            return obj is Angle other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(degrees, minutes, seconds);
        }

        public int CompareTo(object obj)
        {
            Angle temp = (Angle)obj;
            if (this.degrees + this.minutes + this.seconds > temp.degrees + temp.minutes + temp.seconds)
                return 1;
            if (this.degrees + this.minutes + this.seconds < temp.degrees + temp.minutes + temp.seconds)
                return -1;
            else
                return 0;
        }

        public static IComparer SortBySeconds
        {
            get { return (IComparer)new SecondComparer(); }
        }

        public static IComparer SortByDegrees
        {
            get { return (IComparer)new DegreesComparer(); }
        }
        
        #region sorting

        public static Angle operator +(Angle a, Angle b)
        {
            Angle final_angle = new Angle();
            int full_rotations = 0;
            if ((a.seconds + b.seconds) / 60 > 0)
            {
                final_angle.minutes += (a.seconds + b.seconds) / 60;
                final_angle.seconds += (a.seconds + b.seconds) % 60;
            }
            else
                final_angle.seconds = a.seconds + b.seconds;

            if ((final_angle.minutes + a.minutes + b.minutes) / 60 > 0)
            {
                final_angle.degrees += (final_angle.minutes + a.minutes + b.minutes) / 60;
                final_angle.minutes += (a.minutes + b.minutes) % 60;
            }
            else
                final_angle.minutes = a.minutes + b.minutes;

            if ((final_angle.degrees + a.degrees + b.degrees) / 360 > 0)
            {
                full_rotations += (final_angle.degrees + a.degrees + b.degrees) / 360;
                final_angle.degrees += (final_angle.degrees + a.degrees + b.degrees) % 360 - full_rotations;
            }
            else
                final_angle.degrees += a.degrees + b.degrees;

            return final_angle;
        }

        public static Angle operator -(Angle a, Angle b)
        {
            Angle final_angle = new Angle();

            if ((a.degrees == 0) && (a.minutes == 0) && (a.seconds == 0))
            {
                final_angle.degrees = (-1) * b.degrees;
                final_angle.minutes = b.minutes;
                final_angle.seconds = b.seconds;
            }
            else
            {

                if (a.seconds < b.seconds)
                {
                    if (a.minutes < b.minutes)
                    {
                        a.degrees -= 1;
                        a.minutes += 60;
                    }
                    else
                        final_angle.minutes = a.minutes - b.minutes;

                    a.minutes -= 1;
                    a.seconds += 60;
                    final_angle.seconds = a.seconds - b.seconds;
                    final_angle.minutes = a.minutes - b.minutes;
                }
                else
                {
                    if (a.minutes < b.minutes)
                    {
                        a.degrees -= 1;
                        a.minutes += 60;
                    }

                    final_angle.minutes = a.minutes - b.minutes;
                    final_angle.seconds = a.seconds - b.seconds;
                }

                final_angle.degrees = a.degrees - b.degrees;
            }

            return final_angle;
        }

        public static Angle operator *(Angle a, int nr)
        {
            Angle final_angle = new Angle();

            if (nr == 0)
            {
                final_angle.degrees = 0;
                final_angle.minutes = 0;
                final_angle.seconds = 0;
            }
            else
            {
                final_angle.degrees = a.degrees * nr;
                final_angle.minutes = a.minutes * nr;
                final_angle.seconds = a.seconds * nr;
                if (final_angle.seconds / 60 > 0)
                {
                    final_angle.minutes += final_angle.seconds / 60;
                    final_angle.seconds = final_angle.seconds % 60;
                }

                if (final_angle.minutes / 60 > 0)
                {
                    final_angle.degrees += final_angle.minutes / 60;
                    final_angle.minutes = final_angle.minutes % 60;
                }

                if (final_angle.degrees / 360 > 0)
                {
                    final_angle.degrees = final_angle.degrees % 360;
                }
            }

            return final_angle;
        }

        public static Angle operator /(Angle a, int nr)
        {
            Angle final_angle = new Angle();
            final_angle.degrees = a.degrees / nr;
            final_angle.minutes = (a.minutes + (a.degrees % nr) * 60) / nr;
            final_angle.seconds = (a.seconds + (a.minutes % nr) * 60) / nr;
            return final_angle;
        }

        private const double epsilon = 0.0000001;

        public static bool operator ==(Angle a, Angle b)
        {
            if (System.Math.Abs(a.minutes - b.minutes) < epsilon &&
                System.Math.Abs(a.degrees - b.degrees) < epsilon &&
                System.Math.Abs(a.seconds - b.seconds) < epsilon)
                return true;
            else
                return false;
        }

        public static bool operator !=(Angle a, Angle b)
        {
            return !(a == b);
        }

        public int this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0:
                        return degrees;
                    case 1:
                        return minutes;
                    case 2:
                        return seconds;
                    default:
                        throw new IndexOutOfRangeException(
                            "Attempt to retrieve Angle element " + i);
                }
            }
            set
            {
                switch (i)
                {
                    case 0:
                        degrees = value;
                        break;
                    case 1:
                        minutes = value;
                        break;
                    case 2:
                        seconds = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException(
                            "Attempt to set Angle element " + i);
                }
            }
        }
        #endregion
        #region enumerator

        public IEnumerator GetEnumerator()
        {
            //return new AngleEnumerator(this);
            yield return this[0];
            yield return this[1];
            yield return this[2];
        }

        private class AngleEnumerator : IEnumerator
        {
            Angle theAngle; // Angle object that this enumerator refers to
            int location; // which element of theAngle the enumerator is currently referring to

            public AngleEnumerator(Angle theAngle)
            {
                this.theAngle = theAngle;
                location = -1;
            }

            public bool MoveNext()
            {
                ++location;
                return (location > 2) ? false : true;
            }

            public object Current
            {
                get
                {
                    if (location < 0 || location > 2)
                        throw new InvalidOperationException(
                            "The enumerator is either before the first element or " +
                            "after the last element of the Vector");
                    return theAngle[(int)location];
                }
            }

            public void Reset()
            {
                location = -1;
            }
        }

        #endregion
    }
}

