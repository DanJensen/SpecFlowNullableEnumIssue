using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowNullableEnumProblem
{
    [Binding]
    public class TestEntitySteps
    {
        [Given("I have a new TestEntity with the following values")]
        public void NewTestEntity(Table table)
        {
            var entity = table.CreateInstance<TestEntity>();
            ScenarioContext.Current.Set(entity);
        }

        [Then("the value should be set to (.+)")]
        public void ShouldBeSet(string value)
        {
            var entity = ScenarioContext.Current.Get<TestEntity>();
            var expected = (TestEnum)Enum.Parse(typeof(TestEnum), value);

            Assert.AreEqual(expected, entity.TestProperty);
        }
    }
}