using System;

namespace M1M3RestrictionTest
{
    struct Sample
    {
        public DateTime Timestamp;
        public bool RestrictorValve;
        public double Displacement;
        public double MasterControl;
        public double SlaveControl;
        public double MasterSensor;
        public double SlaveSensor;

        public override string ToString()
        {
            return string.Format("{0},{1},{2:0.000},{3:0.000},{4:0.000},{5:0.000},{6:0.000}", Timestamp.ToString("MM/dd/yyyy HH:mm:ss.fff"), RestrictorValve, Displacement, MasterControl, SlaveControl, MasterSensor, SlaveSensor);
        }
    }
}