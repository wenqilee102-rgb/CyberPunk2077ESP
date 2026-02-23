using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseHideUIDetectionEvent : redEvent
	{
		private CBool _shouldHideUIDetection;

		[Ordinal(0)] 
		[RED("shouldHideUIDetection")] 
		public CBool ShouldHideUIDetection
		{
			get => GetProperty(ref _shouldHideUIDetection);
			set => SetProperty(ref _shouldHideUIDetection, value);
		}

		public senseHideUIDetectionEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
