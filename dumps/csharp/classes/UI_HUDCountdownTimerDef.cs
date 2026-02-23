using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_HUDCountdownTimerDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _timerID;
		private gamebbScriptID_Bool _active;
		private gamebbScriptID_Float _progress;

		[Ordinal(0)] 
		[RED("TimerID")] 
		public gamebbScriptID_Variant TimerID
		{
			get => GetProperty(ref _timerID);
			set => SetProperty(ref _timerID, value);
		}

		[Ordinal(1)] 
		[RED("Active")] 
		public gamebbScriptID_Bool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(2)] 
		[RED("Progress")] 
		public gamebbScriptID_Float Progress
		{
			get => GetProperty(ref _progress);
			set => SetProperty(ref _progress, value);
		}

		public UI_HUDCountdownTimerDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
