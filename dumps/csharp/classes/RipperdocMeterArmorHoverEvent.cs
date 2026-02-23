using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocMeterArmorHoverEvent : redEvent
	{
		private CBool _isHover;
		private CFloat _armorChange;
		private CFloat _armorMultiplier;
		private CFloat _currentArmorMultiplier;
		private CFloat _equippedArmorChange;
		private CFloat _equippedArmorMultiplier;
		private CBool _isCyberwareEquipped;

		[Ordinal(0)] 
		[RED("IsHover")] 
		public CBool IsHover
		{
			get => GetProperty(ref _isHover);
			set => SetProperty(ref _isHover, value);
		}

		[Ordinal(1)] 
		[RED("ArmorChange")] 
		public CFloat ArmorChange
		{
			get => GetProperty(ref _armorChange);
			set => SetProperty(ref _armorChange, value);
		}

		[Ordinal(2)] 
		[RED("ArmorMultiplier")] 
		public CFloat ArmorMultiplier
		{
			get => GetProperty(ref _armorMultiplier);
			set => SetProperty(ref _armorMultiplier, value);
		}

		[Ordinal(3)] 
		[RED("CurrentArmorMultiplier")] 
		public CFloat CurrentArmorMultiplier
		{
			get => GetProperty(ref _currentArmorMultiplier);
			set => SetProperty(ref _currentArmorMultiplier, value);
		}

		[Ordinal(4)] 
		[RED("EquippedArmorChange")] 
		public CFloat EquippedArmorChange
		{
			get => GetProperty(ref _equippedArmorChange);
			set => SetProperty(ref _equippedArmorChange, value);
		}

		[Ordinal(5)] 
		[RED("EquippedArmorMultiplier")] 
		public CFloat EquippedArmorMultiplier
		{
			get => GetProperty(ref _equippedArmorMultiplier);
			set => SetProperty(ref _equippedArmorMultiplier, value);
		}

		[Ordinal(6)] 
		[RED("isCyberwareEquipped")] 
		public CBool IsCyberwareEquipped
		{
			get => GetProperty(ref _isCyberwareEquipped);
			set => SetProperty(ref _isCyberwareEquipped, value);
		}

		public RipperdocMeterArmorHoverEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
