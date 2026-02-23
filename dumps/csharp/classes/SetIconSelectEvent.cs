using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetIconSelectEvent : redEvent
	{
		private TweakDBID _iconID;

		[Ordinal(0)] 
		[RED("IconID")] 
		public TweakDBID IconID
		{
			get => GetProperty(ref _iconID);
			set => SetProperty(ref _iconID, value);
		}

		public SetIconSelectEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
