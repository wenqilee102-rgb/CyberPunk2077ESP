using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ColorTemplatePreviewVirtualController : inkVirtualCompoundItemController
	{
		private CName _widgetToSpawn;
		private CHandle<WrappedTemplateData> _wrappedData;
		private wCHandle<inkWidget> _spawnedWidget;
		private wCHandle<ColorTemplatePreviewDisplayController> _templatePreview;
		private CBool _templateToggled;
		private CBool _templateSelected;
		private CBool _canNavigate;
		private CBool _colorCorrectionEnabled;

		[Ordinal(18)] 
		[RED("widgetToSpawn")] 
		public CName WidgetToSpawn
		{
			get => GetProperty(ref _widgetToSpawn);
			set => SetProperty(ref _widgetToSpawn, value);
		}

		[Ordinal(19)] 
		[RED("wrappedData")] 
		public CHandle<WrappedTemplateData> WrappedData
		{
			get => GetProperty(ref _wrappedData);
			set => SetProperty(ref _wrappedData, value);
		}

		[Ordinal(20)] 
		[RED("spawnedWidget")] 
		public wCHandle<inkWidget> SpawnedWidget
		{
			get => GetProperty(ref _spawnedWidget);
			set => SetProperty(ref _spawnedWidget, value);
		}

		[Ordinal(21)] 
		[RED("templatePreview")] 
		public wCHandle<ColorTemplatePreviewDisplayController> TemplatePreview
		{
			get => GetProperty(ref _templatePreview);
			set => SetProperty(ref _templatePreview, value);
		}

		[Ordinal(22)] 
		[RED("templateToggled")] 
		public CBool TemplateToggled
		{
			get => GetProperty(ref _templateToggled);
			set => SetProperty(ref _templateToggled, value);
		}

		[Ordinal(23)] 
		[RED("templateSelected")] 
		public CBool TemplateSelected
		{
			get => GetProperty(ref _templateSelected);
			set => SetProperty(ref _templateSelected, value);
		}

		[Ordinal(24)] 
		[RED("canNavigate")] 
		public CBool CanNavigate
		{
			get => GetProperty(ref _canNavigate);
			set => SetProperty(ref _canNavigate, value);
		}

		[Ordinal(25)] 
		[RED("colorCorrectionEnabled")] 
		public CBool ColorCorrectionEnabled
		{
			get => GetProperty(ref _colorCorrectionEnabled);
			set => SetProperty(ref _colorCorrectionEnabled, value);
		}

		public ColorTemplatePreviewVirtualController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
