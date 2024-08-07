﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowIHMJeuxTennis.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class IHMJeuTennisLaunchAutoFeature : object, Xunit.IClassFixture<IHMJeuTennisLaunchAutoFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "IHMJeuTennisLaunchAuto.feature"
#line hidden
        
        public IHMJeuTennisLaunchAutoFeature(IHMJeuTennisLaunchAutoFeature.FixtureData fixtureData, SpecFlowIHMJeuxTennis_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "IHMJeuTennisLaunchAuto", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
    #line hidden
#line 4
        testRunner.Given("Je suis en \"http://localhost:5144\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Nom",
                        "Prenom"});
            table1.AddRow(new string[] {
                        "Chine",
                        "Dmitri"});
            table1.AddRow(new string[] {
                        "Medvedev",
                        "Daniil"});
#line 5
        testRunner.When("Je clique \"Créer match\" pour", ((string)(null)), table1, "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Joueur",
                        "SETS PRÉCÉDENTS",
                        "Sets",
                        "Jeux",
                        "Points"});
            table2.AddRow(new string[] {
                        "Chine Dmitri",
                        "-",
                        "0",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Medvedev Daniil",
                        "-",
                        "0",
                        "0",
                        "0"});
#line 9
        testRunner.Then("Je dois avoir une vue \"Match\"", ((string)(null)), table2, "Then ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Chauqe joueur ont gagné un point")]
        [Xunit.TraitAttribute("FeatureTitle", "IHMJeuTennisLaunchAuto")]
        [Xunit.TraitAttribute("Description", "Chauqe joueur ont gagné un point")]
        public virtual void ChauqeJoueurOntGagneUnPoint()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Chauqe joueur ont gagné un point", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 14
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
    this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Joueur",
                            "SETS PRÉCÉDENTS",
                            "Sets",
                            "Jeux",
                            "Points"});
                table3.AddRow(new string[] {
                            "Chine Dmitri",
                            "-",
                            "0",
                            "0",
                            "0"});
                table3.AddRow(new string[] {
                            "Medvedev Daniil",
                            "-",
                            "0",
                            "0",
                            "0"});
#line 15
        testRunner.Then("Je dois avoir une vue \"Match\"", ((string)(null)), table3, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "idJoueur"});
                table4.AddRow(new string[] {
                            "1"});
#line 19
        testRunner.When("Je clique \"Gagné point\" pour", ((string)(null)), table4, "When ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "idJoueur"});
                table5.AddRow(new string[] {
                            "2"});
#line 22
        testRunner.And("Je clique \"Gagné point\" pour", ((string)(null)), table5, "And ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "Joueur",
                            "SETS PRÉCÉDENTS",
                            "Sets",
                            "Jeux",
                            "Points"});
                table6.AddRow(new string[] {
                            "Chine Dmitri",
                            "-",
                            "0",
                            "0",
                            "15"});
                table6.AddRow(new string[] {
                            "Medvedev Daniil",
                            "-",
                            "0",
                            "0",
                            "15"});
#line 25
        testRunner.Then("Je dois avoir une vue \"Match\"", ((string)(null)), table6, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                IHMJeuTennisLaunchAutoFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                IHMJeuTennisLaunchAutoFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
