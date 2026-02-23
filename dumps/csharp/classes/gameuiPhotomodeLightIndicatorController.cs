using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotomodeLightIndicatorController : inkWidgetLogicController
	{
		private inkWidgetReference _indicatorRef;
		private inkWidgetReference _indicatorIconRef;
		private inkTextWidgetReference _indicatorNumRef;
		private CFloat _correctionAngle;
		private CInt32 _activeIndex;
		private wCHandle<entEntity> _currentCamera;
		private Vector2 _maxSize;

		[Ordinal(1)] 
		[RED("indicatorRef")] 
		public inkWidgetReference IndicatorRef
		{
			get => GetProperty(ref _indicatorRef);
			set => SetProperty(ref _indicatorRef, value);
		}

		[Ordinal(2)] 
		[RED("indicatorIconRef")] 
		public inkWidgetReference IndicatorIconRef
		{
			get => GetProperty(ref _indicatorIconRef);
			set => SetProperty(ref _indicatorIconRef, value);
		}

		[Ordinal(3)] 
		[RED("indicatorNumRef")] 
		public inkTextWidgetReference IndicatorNumRef
		{
			get => GetProperty(ref _indicatorNumRef);
			set => SetProperty(ref _indicatorNumRef, value);
		}

		[Ordinal(4)] 
		[RED("correctionAngle")] 
		public CFloat CorrectionAngle
		{
			get => GetProperty(ref _correctionAngle);
			set => SetProperty(ref _correctionAngle, value);
		}

		[Ordinal(5)] 
		[RED("activeIndex")] 
		public CInt32 ActiveIndex
		{
			get => GetProperty(ref _activeIndex);
			set => SetProperty(ref _activeIndex, value);
		}

		[Ordinal(6)] 
		[RED("currentCamera")] 
		public wCHandle<entEntity> CurrentCamera
		{
			get => GetProperty(ref _currentCamera);
			set => SetProperty(ref _currentCamera, value);
		}

		[Ordinal(7)] 
		[RED("maxSize")] 
		public Vector2 MaxSize
		{
			get => GetProperty(ref _maxSize);
			set => SetProperty(ref _maxSize, value);
		}

		public gameuiPhotomodeLightIndicatorController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
