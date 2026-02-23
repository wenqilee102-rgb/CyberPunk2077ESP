using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeakspotRequestAttributeChangeEvent : redEvent
	{
		private CBool _blockDamage;
		private CBool _blockHighlight;

		[Ordinal(0)] 
		[RED("blockDamage")] 
		public CBool BlockDamage
		{
			get => GetProperty(ref _blockDamage);
			set => SetProperty(ref _blockDamage, value);
		}

		[Ordinal(1)] 
		[RED("blockHighlight")] 
		public CBool BlockHighlight
		{
			get => GetProperty(ref _blockHighlight);
			set => SetProperty(ref _blockHighlight, value);
		}

		public WeakspotRequestAttributeChangeEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
