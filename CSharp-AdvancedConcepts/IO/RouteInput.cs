using CSharp_AdvancedConcepts.Examples;

namespace CSharp_AdvancedConcepts
{
    public class RouteInput
    {
        internal static void Route(string input)
        {
            if (input is "event")
            {
                EventCLI.EventExample();
            }

            if (input is "delegate")
            {
                DelegateCLI.DelegateExample();
            }

            if (input is "reflection")
            {
                RefelectionExampleCLI.Examples();
            }
        }
    }
}
