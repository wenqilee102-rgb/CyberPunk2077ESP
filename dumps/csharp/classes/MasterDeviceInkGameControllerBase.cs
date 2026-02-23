using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MasterDeviceInkGameControllerBase : DeviceInkGameControllerBase
	{
		private CArray<SThumbnailWidgetPackage> _thumbnailWidgetsData;
		private CHandle<redCallbackObject> _onThumbnailWidgetsUpdateListener;
		private CHandle<redCallbackObject> _onCleanPasswordListener;
		private wCHandle<KeypadDeviceController> _keypadController;

		[Ordinal(16)] 
		[RED("thumbnailWidgetsData")] 
		public CArray<SThumbnailWidgetPackage> ThumbnailWidgetsData
		{
			get => GetProperty(ref _thumbnailWidgetsData);
			set => SetProperty(ref _thumbnailWidgetsData, value);
		}

		[Ordinal(17)] 
		[RED("onThumbnailWidgetsUpdateListener")] 
		public CHandle<redCallbackObject> OnThumbnailWidgetsUpdateListener
		{
			get => GetProperty(ref _onThumbnailWidgetsUpdateListener);
			set => SetProperty(ref _onThumbnailWidgetsUpdateListener, value);
		}

		[Ordinal(18)] 
		[RED("onCleanPasswordListener")] 
		public CHandle<redCallbackObject> OnCleanPasswordListener
		{
			get => GetProperty(ref _onCleanPasswordListener);
			set => SetProperty(ref _onCleanPasswordListener, value);
		}

		[Ordinal(19)] 
		[RED("keypadController")] 
		public wCHandle<KeypadDeviceController> KeypadController
		{
			get => GetProperty(ref _keypadController);
			set => SetProperty(ref _keypadController, value);
		}

		public MasterDeviceInkGameControllerBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
