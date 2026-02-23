using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SimpleMessengerItemVirtualController : inkVirtualCompoundItemController
	{
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _msgPreview;
		private inkWidgetReference _msgIndicator;
		private inkWidgetReference _replyAlertIcon;
		private inkWidgetReference _collapseIcon;
		private inkImageWidgetReference _image;
		private CEnum<MessengerContactType> _type;
		private CHandle<ContactData> _contactData;
		private wCHandle<MessengerContactSyncData> _activeItemSync;
		private CBool _isContactActive;
		private CBool _isItemHovered;
		private CBool _isItemToggled;

		[Ordinal(18)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(19)] 
		[RED("msgPreview")] 
		public inkTextWidgetReference MsgPreview
		{
			get => GetProperty(ref _msgPreview);
			set => SetProperty(ref _msgPreview, value);
		}

		[Ordinal(20)] 
		[RED("msgIndicator")] 
		public inkWidgetReference MsgIndicator
		{
			get => GetProperty(ref _msgIndicator);
			set => SetProperty(ref _msgIndicator, value);
		}

		[Ordinal(21)] 
		[RED("replyAlertIcon")] 
		public inkWidgetReference ReplyAlertIcon
		{
			get => GetProperty(ref _replyAlertIcon);
			set => SetProperty(ref _replyAlertIcon, value);
		}

		[Ordinal(22)] 
		[RED("collapseIcon")] 
		public inkWidgetReference CollapseIcon
		{
			get => GetProperty(ref _collapseIcon);
			set => SetProperty(ref _collapseIcon, value);
		}

		[Ordinal(23)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetProperty(ref _image);
			set => SetProperty(ref _image, value);
		}

		[Ordinal(24)] 
		[RED("type")] 
		public CEnum<MessengerContactType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(25)] 
		[RED("contactData")] 
		public CHandle<ContactData> ContactData
		{
			get => GetProperty(ref _contactData);
			set => SetProperty(ref _contactData, value);
		}

		[Ordinal(26)] 
		[RED("activeItemSync")] 
		public wCHandle<MessengerContactSyncData> ActiveItemSync
		{
			get => GetProperty(ref _activeItemSync);
			set => SetProperty(ref _activeItemSync, value);
		}

		[Ordinal(27)] 
		[RED("isContactActive")] 
		public CBool IsContactActive
		{
			get => GetProperty(ref _isContactActive);
			set => SetProperty(ref _isContactActive, value);
		}

		[Ordinal(28)] 
		[RED("isItemHovered")] 
		public CBool IsItemHovered
		{
			get => GetProperty(ref _isItemHovered);
			set => SetProperty(ref _isItemHovered, value);
		}

		[Ordinal(29)] 
		[RED("isItemToggled")] 
		public CBool IsItemToggled
		{
			get => GetProperty(ref _isItemToggled);
			set => SetProperty(ref _isItemToggled, value);
		}

		public SimpleMessengerItemVirtualController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
