using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LerpToDefaultControllerLightColorRequest : gameScriptableSystemRequest
	{
		private CBool _notQuest;

		[Ordinal(0)] 
		[RED("notQuest")] 
		public CBool NotQuest
		{
			get => GetProperty(ref _notQuest);
			set => SetProperty(ref _notQuest, value);
		}

		public LerpToDefaultControllerLightColorRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
