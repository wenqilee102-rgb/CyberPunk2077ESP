using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EdgrunnerPerkEvent : redEvent
	{
		private CBool _isPurchased;

		[Ordinal(0)] 
		[RED("isPurchased")] 
		public CBool IsPurchased
		{
			get => GetProperty(ref _isPurchased);
			set => SetProperty(ref _isPurchased, value);
		}

		public EdgrunnerPerkEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
