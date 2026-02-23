using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLayerDefinition_NEW : CVariable
	{
		private CName _name;
		private CEnum<inkELayerType> _layerType;
		private CEnum<inkLayerDrawingPolicy> _drawingPolicy;
		private CEnum<inkELayerLoadPriority> _loadPriority;
		private CBool _enabled;
		private CBool _isPermanent;
		private CBool _useGlobalStyleTheme;
		private CBool _isAffectedByFadeout;
		private CBool _useGameInput;
		private CName _inputContext;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("layerType")] 
		public CEnum<inkELayerType> LayerType
		{
			get => GetProperty(ref _layerType);
			set => SetProperty(ref _layerType, value);
		}

		[Ordinal(2)] 
		[RED("drawingPolicy")] 
		public CEnum<inkLayerDrawingPolicy> DrawingPolicy
		{
			get => GetProperty(ref _drawingPolicy);
			set => SetProperty(ref _drawingPolicy, value);
		}

		[Ordinal(3)] 
		[RED("loadPriority")] 
		public CEnum<inkELayerLoadPriority> LoadPriority
		{
			get => GetProperty(ref _loadPriority);
			set => SetProperty(ref _loadPriority, value);
		}

		[Ordinal(4)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(5)] 
		[RED("isPermanent")] 
		public CBool IsPermanent
		{
			get => GetProperty(ref _isPermanent);
			set => SetProperty(ref _isPermanent, value);
		}

		[Ordinal(6)] 
		[RED("useGlobalStyleTheme")] 
		public CBool UseGlobalStyleTheme
		{
			get => GetProperty(ref _useGlobalStyleTheme);
			set => SetProperty(ref _useGlobalStyleTheme, value);
		}

		[Ordinal(7)] 
		[RED("isAffectedByFadeout")] 
		public CBool IsAffectedByFadeout
		{
			get => GetProperty(ref _isAffectedByFadeout);
			set => SetProperty(ref _isAffectedByFadeout, value);
		}

		[Ordinal(8)] 
		[RED("useGameInput")] 
		public CBool UseGameInput
		{
			get => GetProperty(ref _useGameInput);
			set => SetProperty(ref _useGameInput, value);
		}

		[Ordinal(9)] 
		[RED("inputContext")] 
		public CName InputContext
		{
			get => GetProperty(ref _inputContext);
			set => SetProperty(ref _inputContext, value);
		}

		public inkLayerDefinition_NEW(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
