using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GarmentItemPreviewGameController : gameuiBaseGarmentItemPreviewGameController
	{
		private CHandle<InventoryItemPreviewData> _data;
		private CBool _isMouseDown;
		private CFloat _c_GARMENT_ROTATION_SPEED;

		[Ordinal(18)] 
		[RED("data")] 
		public CHandle<InventoryItemPreviewData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(19)] 
		[RED("isMouseDown")] 
		public CBool IsMouseDown
		{
			get => GetProperty(ref _isMouseDown);
			set => SetProperty(ref _isMouseDown, value);
		}

		[Ordinal(20)] 
		[RED("c_GARMENT_ROTATION_SPEED")] 
		public CFloat C_GARMENT_ROTATION_SPEED
		{
			get => GetProperty(ref _c_GARMENT_ROTATION_SPEED);
			set => SetProperty(ref _c_GARMENT_ROTATION_SPEED, value);
		}

		public GarmentItemPreviewGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
