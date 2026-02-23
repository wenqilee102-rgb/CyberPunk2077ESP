using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OverclockDamagePreview : redEvent
	{
		private CBool _isHovering;
		private CBool _justHacked;
		private CInt32 _memoryCost;

		[Ordinal(0)] 
		[RED("IsHovering")] 
		public CBool IsHovering
		{
			get => GetProperty(ref _isHovering);
			set => SetProperty(ref _isHovering, value);
		}

		[Ordinal(1)] 
		[RED("JustHacked")] 
		public CBool JustHacked
		{
			get => GetProperty(ref _justHacked);
			set => SetProperty(ref _justHacked, value);
		}

		[Ordinal(2)] 
		[RED("MemoryCost")] 
		public CInt32 MemoryCost
		{
			get => GetProperty(ref _memoryCost);
			set => SetProperty(ref _memoryCost, value);
		}

		public OverclockDamagePreview(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
