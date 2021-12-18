using Fluxor;
using HSA.Client.Store.FormUseCase.Actions;

namespace HSA.Client.Store.FormUseCase
{
    public class Reducers
    {
        /// <summary>
        /// reduces the passed through parameter 2 updating state
        /// </summary>
        /// <param name="state">current state</param>
        /// <param name="action">the action that it is reducing, even if not used it must still be 
        /// passed as param so that fluxor knows its a reducer for this action
        /// </param>
        /// <returns>new use case state</returns>
        [ReducerMethod]
        public static FormState ReduceIncrementSectionNumberAction(FormState state, IncrementSectionAction action) =>
            new FormState(sectionNumber: state.SectionNumber + 1, questions: state.Questions);

        /// <summary>
        /// reduces the passed through parameter 2 updating state
        /// </summary>
        /// <param name="state">current state</param>
        /// <param name="action">the action that it is reducing, even if not used it must still be 
        /// passed as param so that fluxor knows its a reducer for this action
        /// </param>
        /// <returns>new use case state</returns>
        [ReducerMethod]
        public static FormState ReduceDecrementSectionNumberAction(FormState state, DecrementSectionAction action) =>
            new FormState(sectionNumber: state.SectionNumber - 1, questions: state.Questions);

        /// <summary>
        /// reduces the passed through parameter 2 updating state
        /// </summary>
        /// <param name="state">current state</param>
        /// <param name="action">the action that it is reducing, even if not used it must still be 
        /// passed as param so that fluxor knows its a reducer for this action
        /// </param>
        /// <returns>new use case state</returns>
        [ReducerMethod]
        public static FormState ReduceResetSectionNumberAction(FormState state, ResetSectionNumberAction action) =>
            new FormState(sectionNumber: 0, questions:state.Questions);
    }
}
