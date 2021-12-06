using MudBlazor;

namespace HSA.Client.Util
{
    public class Config
    {
        public record SectionModel(string SectionName, Type Component, string Icon);

        public readonly static List<SectionModel> SectionData = new List<SectionModel>() { 
            new SectionModel("Register", typeof(SectionModel), Icons.Material.Filled.AccountCircle),
            new SectionModel("Assesment", typeof(SectionModel), Icons.Filled.Assignment),
            new SectionModel("Submit", typeof(SectionModel), Icons.Filled.Send),
        };
    }
}
