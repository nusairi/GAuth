﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("GoogleTask service")]
    public partial class GoogleTaskServiceFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Google_OAuth.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GoogleTask service", "Authentication should be provided", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Task")]
        [NUnit.Framework.CategoryAttribute("Sunny")]
        [NUnit.Framework.CategoryAttribute("Sanity")]
        [NUnit.Framework.TestCaseAttribute("1", "Mir\'s list", null)]
        [NUnit.Framework.TestCaseAttribute("2", "Mir\'s list", null)]
        [NUnit.Framework.TestCaseAttribute("3", "Mir\'s list", null)]
        [NUnit.Framework.TestCaseAttribute("4", "Mir\'s list", null)]
        public virtual void CreateTask(string newTaskTitle, string taskListName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Sunny",
                    "Sanity"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Task", @__tags);
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
testRunner.Given("a valid google user is logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
testRunner.When(string.Format("he requested task \"{0}\" creation under taskList \"{1}\"", newTaskTitle, taskListName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
testRunner.Then("the task should be created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Move Task")]
        [NUnit.Framework.CategoryAttribute("Sunny")]
        [NUnit.Framework.CategoryAttribute("Sanity")]
        [NUnit.Framework.TestCaseAttribute("3", "Mir\'s list", null)]
        public virtual void MoveTask(string taskTitle, string taskListName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Sunny",
                    "Sanity"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Move Task", @__tags);
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
testRunner.Given("a valid google user is logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
testRunner.When(string.Format("he requested to move the task \"{0}\" under taskList \"{1}\"", taskTitle, taskListName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
testRunner.Then("the task should be moved", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
