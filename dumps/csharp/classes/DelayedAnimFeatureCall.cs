using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayedAnimFeatureCall : gameDelaySystemScriptedDelayCallbackWrapper
	{
		private CName _featureName;
		private CHandle<animAnimFeature_EquipUnequipItem> _animFeature;
		private CHandle<gamestateMachineGameScriptInterface> _scriptInterface;

		[Ordinal(0)] 
		[RED("featureName")] 
		public CName FeatureName
		{
			get => GetProperty(ref _featureName);
			set => SetProperty(ref _featureName, value);
		}

		[Ordinal(1)] 
		[RED("animFeature")] 
		public CHandle<animAnimFeature_EquipUnequipItem> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(2)] 
		[RED("scriptInterface")] 
		public CHandle<gamestateMachineGameScriptInterface> ScriptInterface
		{
			get => GetProperty(ref _scriptInterface);
			set => SetProperty(ref _scriptInterface, value);
		}

		public DelayedAnimFeatureCall(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
