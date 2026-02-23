using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TwintoneOverrideGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _overrideButtonHit;
		private inkWidgetReference _backButtonHit;
		private inkWidgetReference _templatePreviewContainer;
		private inkWidgetLibraryReference _templatePreviewLibraryRef;
		private wCHandle<ColorTemplatePreviewDisplayController> _currentTemplatePreview;
		private CHandle<TwintoneOverrideData> _overrideData;
		private wCHandle<gameObject> _player;
		private ScriptGameInstance _game;
		private VehicleVisualCustomizationTemplate _templateToDelete;
		private CHandle<inkanimProxy> _outroAnimProxy;

		[Ordinal(2)] 
		[RED("overrideButtonHit")] 
		public inkWidgetReference OverrideButtonHit
		{
			get => GetProperty(ref _overrideButtonHit);
			set => SetProperty(ref _overrideButtonHit, value);
		}

		[Ordinal(3)] 
		[RED("backButtonHit")] 
		public inkWidgetReference BackButtonHit
		{
			get => GetProperty(ref _backButtonHit);
			set => SetProperty(ref _backButtonHit, value);
		}

		[Ordinal(4)] 
		[RED("templatePreviewContainer")] 
		public inkWidgetReference TemplatePreviewContainer
		{
			get => GetProperty(ref _templatePreviewContainer);
			set => SetProperty(ref _templatePreviewContainer, value);
		}

		[Ordinal(5)] 
		[RED("templatePreviewLibraryRef")] 
		public inkWidgetLibraryReference TemplatePreviewLibraryRef
		{
			get => GetProperty(ref _templatePreviewLibraryRef);
			set => SetProperty(ref _templatePreviewLibraryRef, value);
		}

		[Ordinal(6)] 
		[RED("currentTemplatePreview")] 
		public wCHandle<ColorTemplatePreviewDisplayController> CurrentTemplatePreview
		{
			get => GetProperty(ref _currentTemplatePreview);
			set => SetProperty(ref _currentTemplatePreview, value);
		}

		[Ordinal(7)] 
		[RED("overrideData")] 
		public CHandle<TwintoneOverrideData> OverrideData
		{
			get => GetProperty(ref _overrideData);
			set => SetProperty(ref _overrideData, value);
		}

		[Ordinal(8)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(9)] 
		[RED("game")] 
		public ScriptGameInstance Game
		{
			get => GetProperty(ref _game);
			set => SetProperty(ref _game, value);
		}

		[Ordinal(10)] 
		[RED("templateToDelete")] 
		public VehicleVisualCustomizationTemplate TemplateToDelete
		{
			get => GetProperty(ref _templateToDelete);
			set => SetProperty(ref _templateToDelete, value);
		}

		[Ordinal(11)] 
		[RED("outroAnimProxy")] 
		public CHandle<inkanimProxy> OutroAnimProxy
		{
			get => GetProperty(ref _outroAnimProxy);
			set => SetProperty(ref _outroAnimProxy, value);
		}

		public TwintoneOverrideGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
