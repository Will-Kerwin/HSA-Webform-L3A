using Fluxor;

namespace HSA.Client.Store.FormUseCase
{
    public class Feature : Feature<FormState>
    {
        public override string GetName() => "Form";

        protected override FormState GetInitialState() =>
            new FormState(
                    sectionNumber: 0,
                    questions: new List<HSA.Shared.Models.AssesmentQuestions>()
                );
    }
}
