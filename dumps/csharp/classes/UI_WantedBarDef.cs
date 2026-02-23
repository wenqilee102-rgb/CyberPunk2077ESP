using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_WantedBarDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _currentWantedLevel;
		private gamebbScriptID_Int32 _deescalationStages;
		private gamebbScriptID_CName _currentChaseState;
		private gamebbScriptID_Float _blinkingStarsDurationTime;
		private gamebbScriptID_Bool _isDogtown;

		[Ordinal(0)] 
		[RED("CurrentWantedLevel")] 
		public gamebbScriptID_Int32 CurrentWantedLevel
		{
			get => GetProperty(ref _currentWantedLevel);
			set => SetProperty(ref _currentWantedLevel, value);
		}

		[Ordinal(1)] 
		[RED("DeescalationStages")] 
		public gamebbScriptID_Int32 DeescalationStages
		{
			get => GetProperty(ref _deescalationStages);
			set => SetProperty(ref _deescalationStages, value);
		}

		[Ordinal(2)] 
		[RED("CurrentChaseState")] 
		public gamebbScriptID_CName CurrentChaseState
		{
			get => GetProperty(ref _currentChaseState);
			set => SetProperty(ref _currentChaseState, value);
		}

		[Ordinal(3)] 
		[RED("BlinkingStarsDurationTime")] 
		public gamebbScriptID_Float BlinkingStarsDurationTime
		{
			get => GetProperty(ref _blinkingStarsDurationTime);
			set => SetProperty(ref _blinkingStarsDurationTime, value);
		}

		[Ordinal(4)] 
		[RED("IsDogtown")] 
		public gamebbScriptID_Bool IsDogtown
		{
			get => GetProperty(ref _isDogtown);
			set => SetProperty(ref _isDogtown, value);
		}

		public UI_WantedBarDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
