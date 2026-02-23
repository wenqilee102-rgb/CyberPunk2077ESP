using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExpansionBannerController : inkWidgetLogicController
	{
		private inkTextWidgetReference _statusTextRef;
		private inkWidgetReference _inputHintRef;
		private inkWidgetReference _indicatorRef;
		private inkWidgetReference _errorPanelRef;
		private inkWidgetReference _errorIconRef;
		private CEnum<ExpansionStatus> _expansionStatus;
		private wCHandle<inkWidget> _root;

		[Ordinal(1)] 
		[RED("statusTextRef")] 
		public inkTextWidgetReference StatusTextRef
		{
			get => GetProperty(ref _statusTextRef);
			set => SetProperty(ref _statusTextRef, value);
		}

		[Ordinal(2)] 
		[RED("inputHintRef")] 
		public inkWidgetReference InputHintRef
		{
			get => GetProperty(ref _inputHintRef);
			set => SetProperty(ref _inputHintRef, value);
		}

		[Ordinal(3)] 
		[RED("indicatorRef")] 
		public inkWidgetReference IndicatorRef
		{
			get => GetProperty(ref _indicatorRef);
			set => SetProperty(ref _indicatorRef, value);
		}

		[Ordinal(4)] 
		[RED("errorPanelRef")] 
		public inkWidgetReference ErrorPanelRef
		{
			get => GetProperty(ref _errorPanelRef);
			set => SetProperty(ref _errorPanelRef, value);
		}

		[Ordinal(5)] 
		[RED("errorIconRef")] 
		public inkWidgetReference ErrorIconRef
		{
			get => GetProperty(ref _errorIconRef);
			set => SetProperty(ref _errorIconRef, value);
		}

		[Ordinal(6)] 
		[RED("expansionStatus")] 
		public CEnum<ExpansionStatus> ExpansionStatus
		{
			get => GetProperty(ref _expansionStatus);
			set => SetProperty(ref _expansionStatus, value);
		}

		[Ordinal(7)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		public ExpansionBannerController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
