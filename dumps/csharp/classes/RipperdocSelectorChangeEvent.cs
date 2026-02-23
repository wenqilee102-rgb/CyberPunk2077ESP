using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocSelectorChangeEvent : redEvent
	{
		private CInt32 _index;
		private CBool _slidingRight;

		[Ordinal(0)] 
		[RED("Index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(1)] 
		[RED("SlidingRight")] 
		public CBool SlidingRight
		{
			get => GetProperty(ref _slidingRight);
			set => SetProperty(ref _slidingRight, value);
		}

		public RipperdocSelectorChangeEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
