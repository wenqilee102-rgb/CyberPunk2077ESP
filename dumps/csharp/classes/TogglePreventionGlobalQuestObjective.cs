using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TogglePreventionGlobalQuestObjective : gameScriptableSystemRequest
	{
		private CBool _preventionGlobalQuestDisabled;
		private CName _eventSource;

		[Ordinal(0)] 
		[RED("preventionGlobalQuestDisabled")] 
		public CBool PreventionGlobalQuestDisabled
		{
			get => GetProperty(ref _preventionGlobalQuestDisabled);
			set => SetProperty(ref _preventionGlobalQuestDisabled, value);
		}

		[Ordinal(1)] 
		[RED("eventSource")] 
		public CName EventSource
		{
			get => GetProperty(ref _eventSource);
			set => SetProperty(ref _eventSource, value);
		}

		public TogglePreventionGlobalQuestObjective(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
