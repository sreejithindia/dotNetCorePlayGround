using Xunit;
using BasicsPlayGround;

namespace XUnitTestBasics
{
    public class LinqQueriesTest
    {
        private LinqQueries linqQueries;

        public LinqQueriesTest() {
            linqQueries = new LinqQueries();
        }

        [Fact]
        public void EmployeeFilter_Runs_Successfully()
        {
            // Act
            var result = linqQueries.EmployeeFilter();

            // Assert
            Assert.DoesNotContain(5, result);
        }
    }
}
