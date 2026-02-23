using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTooltipsManager : inkWidgetLogicController
	{
		private inkWidgetReference _tooltipsContainer;
		private CBool _flipX;
		private CBool _flipY;
		private CBool _flipVerticalAttachment;
		private inkMargin _rootMargin;
		private inkMargin _screenMargin;
		private CArray<inkWidgetReference> _tooltipRequesters;
		private CArray<CName> _genericTooltipsNames;
		private CArray<TooltipWidgetReference> _tooltipLibrariesReferences;
		private CArray<TooltipWidgetStyledReference> _tooltipLibrariesStyledReferences;
		private redResourceReferenceScriptToken _tooltipsLibrary;
		private redResourceReferenceScriptToken _menuTooltipStylePath;
		private redResourceReferenceScriptToken _hudTooltipStylePath;
		private CBool _prespawnLazyModules;
		private CArray<wCHandle<AGenericTooltipController>> _indexedTooltips;
		private CArray<CHandle<NamedTooltipController>> _namedTooltips;
		private redResourceReferenceScriptToken _tooltipStylePath;
		private CBool _enableTransitionAnimation;
		private CHandle<inkanimDefinition> _tooltipAnimHideDef;
		private CHandle<inkanimDefinition> _tooltipDelayedShowDef;
		private CHandle<inkanimProxy> _tooltipAnimHide;
		private CHandle<inkanimProxy> _tooltipDelayedShow;
		private CHandle<inkanimProxy> _tooltipShowAnimProxy;
		private CFloat _axisDataThreshold;
		private CFloat _mouseDataThreshold;
		private CBool _isHidden;

		[Ordinal(1)] 
		[RED("tooltipsContainer")] 
		public inkWidgetReference TooltipsContainer
		{
			get => GetProperty(ref _tooltipsContainer);
			set => SetProperty(ref _tooltipsContainer, value);
		}

		[Ordinal(2)] 
		[RED("flipX")] 
		public CBool FlipX
		{
			get => GetProperty(ref _flipX);
			set => SetProperty(ref _flipX, value);
		}

		[Ordinal(3)] 
		[RED("flipY")] 
		public CBool FlipY
		{
			get => GetProperty(ref _flipY);
			set => SetProperty(ref _flipY, value);
		}

		[Ordinal(4)] 
		[RED("flipVerticalAttachment")] 
		public CBool FlipVerticalAttachment
		{
			get => GetProperty(ref _flipVerticalAttachment);
			set => SetProperty(ref _flipVerticalAttachment, value);
		}

		[Ordinal(5)] 
		[RED("rootMargin")] 
		public inkMargin RootMargin
		{
			get => GetProperty(ref _rootMargin);
			set => SetProperty(ref _rootMargin, value);
		}

		[Ordinal(6)] 
		[RED("screenMargin")] 
		public inkMargin ScreenMargin
		{
			get => GetProperty(ref _screenMargin);
			set => SetProperty(ref _screenMargin, value);
		}

		[Ordinal(7)] 
		[RED("TooltipRequesters")] 
		public CArray<inkWidgetReference> TooltipRequesters
		{
			get => GetProperty(ref _tooltipRequesters);
			set => SetProperty(ref _tooltipRequesters, value);
		}

		[Ordinal(8)] 
		[RED("GenericTooltipsNames")] 
		public CArray<CName> GenericTooltipsNames
		{
			get => GetProperty(ref _genericTooltipsNames);
			set => SetProperty(ref _genericTooltipsNames, value);
		}

		[Ordinal(9)] 
		[RED("TooltipLibrariesReferences")] 
		public CArray<TooltipWidgetReference> TooltipLibrariesReferences
		{
			get => GetProperty(ref _tooltipLibrariesReferences);
			set => SetProperty(ref _tooltipLibrariesReferences, value);
		}

		[Ordinal(10)] 
		[RED("TooltipLibrariesStyledReferences")] 
		public CArray<TooltipWidgetStyledReference> TooltipLibrariesStyledReferences
		{
			get => GetProperty(ref _tooltipLibrariesStyledReferences);
			set => SetProperty(ref _tooltipLibrariesStyledReferences, value);
		}

		[Ordinal(11)] 
		[RED("TooltipsLibrary")] 
		public redResourceReferenceScriptToken TooltipsLibrary
		{
			get => GetProperty(ref _tooltipsLibrary);
			set => SetProperty(ref _tooltipsLibrary, value);
		}

		[Ordinal(12)] 
		[RED("MenuTooltipStylePath")] 
		public redResourceReferenceScriptToken MenuTooltipStylePath
		{
			get => GetProperty(ref _menuTooltipStylePath);
			set => SetProperty(ref _menuTooltipStylePath, value);
		}

		[Ordinal(13)] 
		[RED("HudTooltipStylePath")] 
		public redResourceReferenceScriptToken HudTooltipStylePath
		{
			get => GetProperty(ref _hudTooltipStylePath);
			set => SetProperty(ref _hudTooltipStylePath, value);
		}

		[Ordinal(14)] 
		[RED("prespawnLazyModules")] 
		public CBool PrespawnLazyModules
		{
			get => GetProperty(ref _prespawnLazyModules);
			set => SetProperty(ref _prespawnLazyModules, value);
		}

		[Ordinal(15)] 
		[RED("IndexedTooltips")] 
		public CArray<wCHandle<AGenericTooltipController>> IndexedTooltips
		{
			get => GetProperty(ref _indexedTooltips);
			set => SetProperty(ref _indexedTooltips, value);
		}

		[Ordinal(16)] 
		[RED("NamedTooltips")] 
		public CArray<CHandle<NamedTooltipController>> NamedTooltips
		{
			get => GetProperty(ref _namedTooltips);
			set => SetProperty(ref _namedTooltips, value);
		}

		[Ordinal(17)] 
		[RED("TooltipStylePath")] 
		public redResourceReferenceScriptToken TooltipStylePath
		{
			get => GetProperty(ref _tooltipStylePath);
			set => SetProperty(ref _tooltipStylePath, value);
		}

		[Ordinal(18)] 
		[RED("enableTransitionAnimation")] 
		public CBool EnableTransitionAnimation
		{
			get => GetProperty(ref _enableTransitionAnimation);
			set => SetProperty(ref _enableTransitionAnimation, value);
		}

		[Ordinal(19)] 
		[RED("tooltipAnimHideDef")] 
		public CHandle<inkanimDefinition> TooltipAnimHideDef
		{
			get => GetProperty(ref _tooltipAnimHideDef);
			set => SetProperty(ref _tooltipAnimHideDef, value);
		}

		[Ordinal(20)] 
		[RED("tooltipDelayedShowDef")] 
		public CHandle<inkanimDefinition> TooltipDelayedShowDef
		{
			get => GetProperty(ref _tooltipDelayedShowDef);
			set => SetProperty(ref _tooltipDelayedShowDef, value);
		}

		[Ordinal(21)] 
		[RED("tooltipAnimHide")] 
		public CHandle<inkanimProxy> TooltipAnimHide
		{
			get => GetProperty(ref _tooltipAnimHide);
			set => SetProperty(ref _tooltipAnimHide, value);
		}

		[Ordinal(22)] 
		[RED("tooltipDelayedShow")] 
		public CHandle<inkanimProxy> TooltipDelayedShow
		{
			get => GetProperty(ref _tooltipDelayedShow);
			set => SetProperty(ref _tooltipDelayedShow, value);
		}

		[Ordinal(23)] 
		[RED("tooltipShowAnimProxy")] 
		public CHandle<inkanimProxy> TooltipShowAnimProxy
		{
			get => GetProperty(ref _tooltipShowAnimProxy);
			set => SetProperty(ref _tooltipShowAnimProxy, value);
		}

		[Ordinal(24)] 
		[RED("axisDataThreshold")] 
		public CFloat AxisDataThreshold
		{
			get => GetProperty(ref _axisDataThreshold);
			set => SetProperty(ref _axisDataThreshold, value);
		}

		[Ordinal(25)] 
		[RED("mouseDataThreshold")] 
		public CFloat MouseDataThreshold
		{
			get => GetProperty(ref _mouseDataThreshold);
			set => SetProperty(ref _mouseDataThreshold, value);
		}

		[Ordinal(26)] 
		[RED("isHidden")] 
		public CBool IsHidden
		{
			get => GetProperty(ref _isHidden);
			set => SetProperty(ref _isHidden, value);
		}

		public gameuiTooltipsManager(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
