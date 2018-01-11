﻿namespace AdvancedMultiSelect.Plugins.Entities.ItemSetConfiguration.Actions.AddControlToFormWizard
{
  using Logic.ItemSetConfiguration;

  using Microsoft.Xrm.Sdk;

  // ReSharper disable once RedundantExtendsListEntry
  public class GetWizardData : PluginBase<Entity>, IPlugin
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="GetWizardData" /> class.
    /// </summary>
    public GetWizardData()
      : base(typeof(GetWizardData))
    {
      this.RegisteredPluginSteps.Add(new PluginStepBase
      {
        Stage = Stage.PostOperation,
        Mode = Mode.Synchronous,
        MessageName = MessageName.pavelkh_ItemSetConfigurationGetAddControlWizardData,
        Handler = this.Process
      });
    }

    private void Process(PluginContext pluginContext)
    {
      var manager = new ItemSetConfigurationActionManager(pluginContext);
      manager.ProcessGetAddControlWizardData();
    }
  }
}
