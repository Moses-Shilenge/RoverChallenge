using System;

namespace Mars.Rover
{
    public class LandingSurface
    {
        public Size Size { get; set; }

        public void SetSize(Size size)
        {
            this.Size = size;
        }

        public object GetSize()
        {
            return this.Size;
        }
    }
}