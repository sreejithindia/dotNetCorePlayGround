using System.Collections;

namespace BasicsPlayGround
{
    public class Queues
    {
        public Queue QueueBasic() {
            var queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("asd");
            queue.Enqueue(3);
            queue.Dequeue();
            return queue;
        }
    }
}
