using System;

using R5T.T0064;


namespace R5T.Angleterria
{
    [ServiceDefinitionMarker]
    public interface IVisualStudioStringlyTypedPathPartsOperator : IServiceDefinition
    {
        string GetProjectDirectoryNameForProjectName(string projectName);
    }
}
