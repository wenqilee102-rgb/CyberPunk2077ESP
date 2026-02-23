using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WardrobeOutfitSlotController : inkWidgetLogicController
	{
		private inkTextWidgetReference _slotNumberText;
		private inkWidgetReference _newSetIndicator;
		private CInt32 _index;
		private CBool _hovered;
		private CBool _active;
		private CBool _equipped;
		private CBool _isNew;

		[Ordinal(1)] 
		[RED("slotNumberText")] 
		public inkTextWidgetReference SlotNumberText
		{
			get => GetProperty(ref _slotNumberText);
			set => SetProperty(ref _slotNumberText, value);
		}

		[Ordinal(2)] 
		[RED("newSetIndicator")] 
		public inkWidgetReference NewSetIndicator
		{
			get => GetProperty(ref _newSetIndicator);
			set => SetProperty(ref _newSetIndicator, value);
		}

		[Ordinal(3)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(4)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetProperty(ref _hovered);
			set => SetProperty(ref _hovered, value);
		}

		[Ordinal(5)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(6)] 
		[RED("equipped")] 
		public CBool Equipped
		{
			get => GetProperty(ref _equipped);
			set => SetProperty(ref _equipped, value);
		}

		[Ordinal(7)] 
		[RED("isNew")] 
		public CBool IsNew
		{
			get => GetProperty(ref _isNew);
			set => SetProperty(ref _isNew, value);
		}

		public WardrobeOutfitSlotController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
