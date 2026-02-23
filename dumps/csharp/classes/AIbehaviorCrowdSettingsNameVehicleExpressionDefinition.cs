using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCrowdSettingsNameVehicleExpressionDefinition : AIbehaviorVehicleExpressionDefinition
	{
		private CName _settingsName;

		[Ordinal(0)] 
		[RED("settingsName")] 
		public CName SettingsName
		{
			get => GetProperty(ref _settingsName);
			set => SetProperty(ref _settingsName, value);
		}

		public AIbehaviorCrowdSettingsNameVehicleExpressionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
