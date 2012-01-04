namespace SpecFlowNullableEnumProblem
{
    public enum TestEnum
    {
        Value1,
        Value2,
        Value3
    }

    public class TestEntity
    {
        public TestEnum? TestProperty { get; set; }
    }
}