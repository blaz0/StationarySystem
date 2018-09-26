We could not find a data exchange file at the path System.Configuration.ConfigurationErrorsException: The element <unitTestProvider> may only appear once in this section.

Please open an issue at https://github.com/techtalk/SpecFlow/issues/
Complete output: 
System.Configuration.ConfigurationErrorsException: The element <unitTestProvider> may only appear once in this section.
   at System.Configuration.ConfigurationElement.DeserializeElement(XmlReader reader, Boolean serializeCollectionKey)
   at System.Configuration.ConfigurationSection.DeserializeSection(XmlReader reader)
   at TechTalk.SpecFlow.Configuration.ConfigurationSectionHandler.CreateFromXml(String xmlContent)
   at TechTalk.SpecFlow.Configuration.ConfigurationLoader.Load(SpecFlowConfiguration specFlowConfiguration, ISpecFlowConfigurationHolder specFlowConfigurationHolder)
   at TechTalk.SpecFlow.Generator.Configuration.GeneratorConfigurationProvider.LoadConfiguration(SpecFlowConfiguration specFlowConfiguration, SpecFlowConfigurationHolder specFlowConfigurationHolder)
   at TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.CreateContainer(SpecFlowConfigurationHolder configurationHolder, ProjectSettings projectSettings)
   at TechTalk.SpecFlow.Generator.TestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
   at TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.Actions.GenerateTestFileAction.GenerateTestFile(GenerateTestFileParameters opts)



Command: c:\users\maxinek01\appdata\local\microsoft\visualstudio\15.0_efe7ebb8\extensions\e5pcub3t.rqh\TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.exe
Parameters: GenerateTestFile --featurefile C:\Users\MaxineK01\AppData\Local\Temp\tmp5D08.tmp --outputdirectory C:\Users\MaxineK01\AppData\Local\Temp --projectsettingsfile C:\Users\MaxineK01\AppData\Local\Temp\tmp5D07.tmp
Working Directory: C:\Users\MaxineK01\source\repos\StationarySystem\packages\SpecFlow.2.4.0\tools