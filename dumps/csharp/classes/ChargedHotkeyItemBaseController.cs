using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChargedHotkeyItemBaseController : HotkeyItemController
	{
		private inkWidgetReference _chargebarSizeWidget;
		private inkWidgetReference _chargebarOpacityWidget;
		private Vector2 _startSize;
		private Vector2 _endSize;
		private CFloat _chargebarOpacity;
		private CHandle<ChargedHotkeyItemStatListener> _statListener;
		private CFloat _currentProgress;
		private CHandle<inkanimProxy> _hideChargesAnimProxy;
		private CHandle<inkanimProxy> _showChargesAnimProxy;
		private CFloat _chargeThreshold;

		[Ordinal(35)] 
		[RED("chargebarSizeWidget")] 
		public inkWidgetReference ChargebarSizeWidget
		{
			get => GetProperty(ref _chargebarSizeWidget);
			set => SetProperty(ref _chargebarSizeWidget, value);
		}

		[Ordinal(36)] 
		[RED("chargebarOpacityWidget")] 
		public inkWidgetReference ChargebarOpacityWidget
		{
			get => GetProperty(ref _chargebarOpacityWidget);
			set => SetProperty(ref _chargebarOpacityWidget, value);
		}

		[Ordinal(37)] 
		[RED("startSize")] 
		public Vector2 StartSize
		{
			get => GetProperty(ref _startSize);
			set => SetProperty(ref _startSize, value);
		}

		[Ordinal(38)] 
		[RED("endSize")] 
		public Vector2 EndSize
		{
			get => GetProperty(ref _endSize);
			set => SetProperty(ref _endSize, value);
		}

		[Ordinal(39)] 
		[RED("chargebarOpacity")] 
		public CFloat ChargebarOpacity
		{
			get => GetProperty(ref _chargebarOpacity);
			set => SetProperty(ref _chargebarOpacity, value);
		}

		[Ordinal(40)] 
		[RED("statListener")] 
		public CHandle<ChargedHotkeyItemStatListener> StatListener
		{
			get => GetProperty(ref _statListener);
			set => SetProperty(ref _statListener, value);
		}

		[Ordinal(41)] 
		[RED("currentProgress")] 
		public CFloat CurrentProgress
		{
			get => GetProperty(ref _currentProgress);
			set => SetProperty(ref _currentProgress, value);
		}

		[Ordinal(42)] 
		[RED("hideChargesAnimProxy")] 
		public CHandle<inkanimProxy> HideChargesAnimProxy
		{
			get => GetProperty(ref _hideChargesAnimProxy);
			set => SetProperty(ref _hideChargesAnimProxy, value);
		}

		[Ordinal(43)] 
		[RED("showChargesAnimProxy")] 
		public CHandle<inkanimProxy> ShowChargesAnimProxy
		{
			get => GetProperty(ref _showChargesAnimProxy);
			set => SetProperty(ref _showChargesAnimProxy, value);
		}

		[Ordinal(44)] 
		[RED("chargeThreshold")] 
		public CFloat ChargeThreshold
		{
			get => GetProperty(ref _chargeThreshold);
			set => SetProperty(ref _chargeThreshold, value);
		}

		public ChargedHotkeyItemBaseController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
