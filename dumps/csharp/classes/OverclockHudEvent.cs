using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OverclockHudEvent : redEvent
	{
		private CBool _activated;

		[Ordinal(0)] 
		[RED("activated")] 
		public CBool Activated
		{
			get => GetProperty(ref _activated);
			set => SetProperty(ref _activated, value);
		}

		public OverclockHudEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
