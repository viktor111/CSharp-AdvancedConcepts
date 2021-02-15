namespace CSharp_AdvancedConcepts
{
    public class MainLoop
    {
        internal static void StartLoop()
        {
            string input = string.Empty;
            while (true)
            {
                input = InputCapture.Capture();

                RouteInput.Route(input);
            }
        }
    }
}
