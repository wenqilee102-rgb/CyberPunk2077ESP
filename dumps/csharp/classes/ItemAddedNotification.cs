using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemAddedNotification : GenericNotificationController
	{
		private inkImageWidgetReference _itemImage;
		private inkWidgetReference _rarityBar;
		private CEnum<gameItemIconGender> _itemIconGender;
		private CName _animationName;

		[Ordinal(16)] 
		[RED("itemImage")] 
		public inkImageWidgetReference ItemImage
		{
			get => GetProperty(ref _itemImage);
			set => SetProperty(ref _itemImage, value);
		}

		[Ordinal(17)] 
		[RED("rarityBar")] 
		public inkWidgetReference RarityBar
		{
			get => GetProperty(ref _rarityBar);
			set => SetProperty(ref _rarityBar, value);
		}

		[Ordinal(18)] 
		[RED("itemIconGender")] 
		public CEnum<gameItemIconGender> ItemIconGender
		{
			get => GetProperty(ref _itemIconGender);
			set => SetProperty(ref _itemIconGender, value);
		}

		[Ordinal(19)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		public ItemAddedNotification(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
