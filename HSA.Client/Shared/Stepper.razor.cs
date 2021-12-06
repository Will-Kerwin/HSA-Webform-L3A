using Microsoft.AspNetCore.Components;

namespace HSA.Client.Shared
{
    public partial class Stepper
    {
        [Parameter]
        public int ActiveStep { get; set; }
    }
}
