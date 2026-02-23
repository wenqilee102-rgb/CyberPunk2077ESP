using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestForceCameraZoom : ActionBool
	{
		private CBool _useWorkspot;
		private CBool _instant;

		[Ordinal(39)] 
		[RED("useWorkspot")] 
		public CBool UseWorkspot
		{
			get => GetProperty(ref _useWorkspot);
			set => SetProperty(ref _useWorkspot, value);
		}

		[Ordinal(40)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetProperty(ref _instant);
			set => SetProperty(ref _instant, value);
		}

		public QuestForceCameraZoom(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
