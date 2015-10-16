using System;
using TechTalk.SpecFlow;

namespace Prueba.Specs
{
    [Binding]
    public class ConsultarCasoSteps
    {
        [Given(@"a number in a textbox")]
        public void GivenANumberInATextbox()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"and verify this field is not empty")]
        public void GivenAndVerifyThisFieldIsNotEmpty()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"press the button consultar")]
        public void WhenPressTheButtonConsultar()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the fields are visible and show the information")]
        public void ThenTheFieldsAreVisibleAndShowTheInformation()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
