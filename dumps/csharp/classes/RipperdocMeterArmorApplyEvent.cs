using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocMeterArmorApplyEvent : redEvent
	{
		private CHandle<RipperdocArmorData> _armorData;
		private CBool _isPurchase;

		[Ordinal(0)] 
		[RED("ArmorData")] 
		public CHandle<RipperdocArmorData> ArmorData
		{
			get => GetProperty(ref _armorData);
			set => SetProperty(ref _armorData, value);
		}

		[Ordinal(1)] 
		[RED("IsPurchase")] 
		public CBool IsPurchase
		{
			get => GetProperty(ref _isPurchase);
			set => SetProperty(ref _isPurchase, value);
		}

		public RipperdocMeterArmorApplyEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
