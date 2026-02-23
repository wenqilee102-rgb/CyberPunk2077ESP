using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocMeterCapacityHoverEvent : redEvent
	{
		private CBool _isHover;
		private CInt32 _capacityChange;
		private CBool _isCyberwareEquipped;

		[Ordinal(0)] 
		[RED("IsHover")] 
		public CBool IsHover
		{
			get => GetProperty(ref _isHover);
			set => SetProperty(ref _isHover, value);
		}

		[Ordinal(1)] 
		[RED("CapacityChange")] 
		public CInt32 CapacityChange
		{
			get => GetProperty(ref _capacityChange);
			set => SetProperty(ref _capacityChange, value);
		}

		[Ordinal(2)] 
		[RED("isCyberwareEquipped")] 
		public CBool IsCyberwareEquipped
		{
			get => GetProperty(ref _isCyberwareEquipped);
			set => SetProperty(ref _isCyberwareEquipped, value);
		}

		public RipperdocMeterCapacityHoverEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
