using Patterns.ChainOfResponsibility.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility
{
    class ChainOfResponsibilityTest : IPatternTest
    {
        public void Run()
        {
            var productManager = TeamFactory.CreateProductManager("Vera Summers");
            var teamLeader = TeamFactory.CreateTeamLeader("Ilya Vasilyev", productManager);
            var developer = TeamFactory.CreateDeveloper("Timur Magarlamov", teamLeader);
            var tester = TeamFactory.CreateTester("Ilya Popov", teamLeader);

            developer.HandleSimpleRefactoringRequest("We obviously need to refactor GetRisks() method");
            developer.HandlePageBehaviorChangeRequest("Chart at the home page looks poor; let's change its design");
            tester.HandleCarebookFunctionalityChangeRequest("Let's implement mobile design for Carebook!");

            Console.ReadKey();
        }
    }
}
