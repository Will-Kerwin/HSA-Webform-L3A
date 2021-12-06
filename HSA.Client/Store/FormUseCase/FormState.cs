using HSA.Shared.Models;

namespace HSA.Client.Store.FormUseCase
{
    public class FormState
    {
        public FormState(int sectionNumber, List<AssesmentQuestions> questions)
        {
            SectionNumber = sectionNumber;
            Questions = questions;
        }

        public int SectionNumber { get; }

        public List<AssesmentQuestions> Questions {get;} 
    }
}
