using System.Collections;
using BasicsPlayGround;
using Xunit;

namespace XUnitTestBasics
{
    public class QueueTest
    {
        public Queues queues;
        public QueueTest() {
            queues = new Queues();
        }

        [Fact]
        public void Queues_Runs_Successfully()
        {
            // Act
            var result = queues.QueueBasic();

            // Assert
            Assert.IsType<Queue>(result);
        }

    }
}
