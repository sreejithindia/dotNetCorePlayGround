using System.Collections.Generic;
using System.Linq;

namespace BasicsPlayGround
{
    public class LinqQueries
    {
        public List<int> EmployeeFilter()
        {
            var employeeIds = new List<int>() { 1, 2, 3, 4, 5, 6 };
            var employeeIdToRemove = 5;
            var result = employeeIds.Distinct().Where(x => x != employeeIdToRemove).ToList();
            return result;
        }

        public List<decimal> GetLoanAmounts()
        {
            decimal[] loanAmounts = { 303m, 1000m, 85579m, 22m, 400m };
            IEnumerable<decimal> loanQuery = 
                from amount in loanAmounts
                where amount % 2 == 0
                orderby amount ascending
                select amount;
            return loanQuery.ToList();
        } 

    }
}
