using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForceExitDelamainEvent : redEvent
	{
		private CBool _shouldExit;

		[Ordinal(0)] 
		[RED("shouldExit")] 
		public CBool ShouldExit
		{
			get => GetProperty(ref _shouldExit);
			set => SetProperty(ref _shouldExit, value);
		}

		public ForceExitDelamainEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
