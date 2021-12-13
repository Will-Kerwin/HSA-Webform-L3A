using MudBlazor;
using HSA.Client.Shared;

namespace HSA.Client.Util
{
    public class Config
    {
        public record SectionModel(string SectionName, Type Component, string Icon);

        public readonly static List<SectionModel> SectionData = new List<SectionModel>() { 
            new SectionModel("Register", typeof(Register), Icons.Material.Filled.AccountCircle),
            new SectionModel("Assesment", typeof(Assesment), Icons.Filled.Assignment),
            new SectionModel("Submit", typeof(Submit), Icons.Filled.Send),
        };
    }
}
