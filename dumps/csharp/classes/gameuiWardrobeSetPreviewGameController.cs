using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiWardrobeSetPreviewGameController : gameuiBaseGarmentItemPreviewGameController
	{
		private inkWidgetReference _colliderWidgetRef;
		private wCHandle<inkWidget> _colliderWidget;
		private CHandle<InventoryItemPreviewData> _data;
		private CBool _isMouseDown;
		private CBool _isNotification;
		private CFloat _c_GARMENT_ROTATION_SPEED;

		[Ordinal(18)] 
		[RED("colliderWidgetRef")] 
		public inkWidgetReference ColliderWidgetRef
		{
			get => GetProperty(ref _colliderWidgetRef);
			set => SetProperty(ref _colliderWidgetRef, value);
		}

		[Ordinal(19)] 
		[RED("colliderWidget")] 
		public wCHandle<inkWidget> ColliderWidget
		{
			get => GetProperty(ref _colliderWidget);
			set => SetProperty(ref _colliderWidget, value);
		}

		[Ordinal(20)] 
		[RED("data")] 
		public CHandle<InventoryItemPreviewData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(21)] 
		[RED("isMouseDown")] 
		public CBool IsMouseDown
		{
			get => GetProperty(ref _isMouseDown);
			set => SetProperty(ref _isMouseDown, value);
		}

		[Ordinal(22)] 
		[RED("isNotification")] 
		public CBool IsNotification
		{
			get => GetProperty(ref _isNotification);
			set => SetProperty(ref _isNotification, value);
		}

		[Ordinal(23)] 
		[RED("c_GARMENT_ROTATION_SPEED")] 
		public CFloat C_GARMENT_ROTATION_SPEED
		{
			get => GetProperty(ref _c_GARMENT_ROTATION_SPEED);
			set => SetProperty(ref _c_GARMENT_ROTATION_SPEED, value);
		}

		public gameuiWardrobeSetPreviewGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
