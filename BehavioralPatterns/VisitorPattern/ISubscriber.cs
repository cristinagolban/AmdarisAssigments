using System;

namespace VisitorPattern
{
    public interface ISubscriber
    {
        void Notify(Tuple<Shape, float> item);
    }
}
