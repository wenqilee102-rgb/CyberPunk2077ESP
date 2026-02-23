using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TwintoneTemplateGridController : inkGridController
	{
		private CHandle<inkScriptableDataSourceWrapper> _templatesDataSource;
		private CHandle<inkScriptableDataViewWrapper> _templatesDataView;
		private CHandle<VehicleVisualCustomizationTemplateClassifier> _templatesDataClassifier;
		private CHandle<VehicleVisualCustomizationTemplatePositionProvider> _templatePositionProvider;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<ColorTemplatePreviewVirtualController> _toggledController;
		private wCHandle<ColorTemplatePreviewVirtualController> _selectedController;
		private CBool _canNavigate;
		private CBool _colorCorrectionEnabled;
		private CBool _enabled;

		[Ordinal(12)] 
		[RED("templatesDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> TemplatesDataSource
		{
			get => GetProperty(ref _templatesDataSource);
			set => SetProperty(ref _templatesDataSource, value);
		}

		[Ordinal(13)] 
		[RED("templatesDataView")] 
		public CHandle<inkScriptableDataViewWrapper> TemplatesDataView
		{
			get => GetProperty(ref _templatesDataView);
			set => SetProperty(ref _templatesDataView, value);
		}

		[Ordinal(14)] 
		[RED("templatesDataClassifier")] 
		public CHandle<VehicleVisualCustomizationTemplateClassifier> TemplatesDataClassifier
		{
			get => GetProperty(ref _templatesDataClassifier);
			set => SetProperty(ref _templatesDataClassifier, value);
		}

		[Ordinal(15)] 
		[RED("templatePositionProvider")] 
		public CHandle<VehicleVisualCustomizationTemplatePositionProvider> TemplatePositionProvider
		{
			get => GetProperty(ref _templatePositionProvider);
			set => SetProperty(ref _templatePositionProvider, value);
		}

		[Ordinal(16)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(17)] 
		[RED("toggledController")] 
		public wCHandle<ColorTemplatePreviewVirtualController> ToggledController
		{
			get => GetProperty(ref _toggledController);
			set => SetProperty(ref _toggledController, value);
		}

		[Ordinal(18)] 
		[RED("selectedController")] 
		public wCHandle<ColorTemplatePreviewVirtualController> SelectedController
		{
			get => GetProperty(ref _selectedController);
			set => SetProperty(ref _selectedController, value);
		}

		[Ordinal(19)] 
		[RED("canNavigate")] 
		public CBool CanNavigate
		{
			get => GetProperty(ref _canNavigate);
			set => SetProperty(ref _canNavigate, value);
		}

		[Ordinal(20)] 
		[RED("colorCorrectionEnabled")] 
		public CBool ColorCorrectionEnabled
		{
			get => GetProperty(ref _colorCorrectionEnabled);
			set => SetProperty(ref _colorCorrectionEnabled, value);
		}

		[Ordinal(21)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		public TwintoneTemplateGridController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
