using Machine.Data.Interfaces.Factories;
using Machine.Data.Interfaces.Tools;
using Machine.Data.Tools;

namespace Machine.Data.Factories
{
    public class ToolFactory : IToolFactory
    {
        public ToolFactory()
        {
            SimpleFactory<ISimpleTool>.Register<SimpleTool>();
            SimpleFactory<IPointedTool>.Register<PointedTool>();
            SimpleFactory<ITwoSectionTool>.Register<TwoSectionTool>();
            SimpleFactory<ICountersinkTool>.Register<CountersinkTool>();
            SimpleFactory<IDiskTool>.Register<DiskTool>();
            SimpleFactory<IDiskOnConeTool>.Register<DiskOnConeTool>();
            SimpleFactory<IAngularTransmission>.Register<AngularTransmission>();
        }

        T IToolFactory.Create<T>() => SimpleFactory<T>.Create();
    }
}
