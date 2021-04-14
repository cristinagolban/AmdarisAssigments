using System.Collections.Generic;

namespace VisitorPattern
{
    public abstract class AbstractPublisher
    {
        private List<ISubscriber> subscribers;

        public AbstractPublisher()
        {
            this.subscribers = new List<ISubscriber>();
        }

        public void AddSubscriber(ISubscriber subscriber)
        {
            this.subscribers.Add(subscriber);
        }

        public void Publish(System.Tuple<Shape, float> item)
        {
            this.subscribers.ForEach(s => s.Notify(item));
        }
    }
}
