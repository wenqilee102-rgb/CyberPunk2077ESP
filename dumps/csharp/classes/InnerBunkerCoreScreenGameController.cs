using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InnerBunkerCoreScreenGameController : BaseInnerBunkerComputerGameController
	{
		private CArrayFixedSize<inkWidgetReference> _systems;
		private CArrayFixedSize<CEnum<InnerBunkerCoreStatus>> _statuses;
		private inkWidgetReference _shutdownButton;
		private inkWidgetReference _processingPanel;
		private inkWidgetReference _failurePopup;
		private inkWidgetReference _successPopup;
		private CFloat _systemCheckTimeOffline;
		private CFloat _systemCheckTimeUnresponsive;
		private CFloat _showResultTime;
		private CName _systemsCheckAnimName;
		private CName _coreStatusNormalAnimName;
		private CName _coreStatusMalfunctionAnimName;
		private CName _coreStatusShutdownAnimName;
		private CName _coreStatusShutingDownAnimName;
		private CName _failurePopupAnimName;
		private CName _successPopupAnimName;
		private CEnum<InnerBunkerCoreStage> _stage;
		private CInt32 _sysIndex;
		private CHandle<inkanimProxy> _systemsCheckAnimProxy;
		private CHandle<inkanimProxy> _resultPopupAnimProxy;
		private CHandle<inkanimProxy> _coreStatusAnimProxy;

		[Ordinal(2)] 
		[RED("systems", 6)] 
		public CArrayFixedSize<inkWidgetReference> Systems
		{
			get => GetProperty(ref _systems);
			set => SetProperty(ref _systems, value);
		}

		[Ordinal(3)] 
		[RED("statuses", 6)] 
		public CArrayFixedSize<CEnum<InnerBunkerCoreStatus>> Statuses
		{
			get => GetProperty(ref _statuses);
			set => SetProperty(ref _statuses, value);
		}

		[Ordinal(4)] 
		[RED("shutdownButton")] 
		public inkWidgetReference ShutdownButton
		{
			get => GetProperty(ref _shutdownButton);
			set => SetProperty(ref _shutdownButton, value);
		}

		[Ordinal(5)] 
		[RED("processingPanel")] 
		public inkWidgetReference ProcessingPanel
		{
			get => GetProperty(ref _processingPanel);
			set => SetProperty(ref _processingPanel, value);
		}

		[Ordinal(6)] 
		[RED("failurePopup")] 
		public inkWidgetReference FailurePopup
		{
			get => GetProperty(ref _failurePopup);
			set => SetProperty(ref _failurePopup, value);
		}

		[Ordinal(7)] 
		[RED("successPopup")] 
		public inkWidgetReference SuccessPopup
		{
			get => GetProperty(ref _successPopup);
			set => SetProperty(ref _successPopup, value);
		}

		[Ordinal(8)] 
		[RED("systemCheckTimeOffline")] 
		public CFloat SystemCheckTimeOffline
		{
			get => GetProperty(ref _systemCheckTimeOffline);
			set => SetProperty(ref _systemCheckTimeOffline, value);
		}

		[Ordinal(9)] 
		[RED("systemCheckTimeUnresponsive")] 
		public CFloat SystemCheckTimeUnresponsive
		{
			get => GetProperty(ref _systemCheckTimeUnresponsive);
			set => SetProperty(ref _systemCheckTimeUnresponsive, value);
		}

		[Ordinal(10)] 
		[RED("showResultTime")] 
		public CFloat ShowResultTime
		{
			get => GetProperty(ref _showResultTime);
			set => SetProperty(ref _showResultTime, value);
		}

		[Ordinal(11)] 
		[RED("systemsCheckAnimName")] 
		public CName SystemsCheckAnimName
		{
			get => GetProperty(ref _systemsCheckAnimName);
			set => SetProperty(ref _systemsCheckAnimName, value);
		}

		[Ordinal(12)] 
		[RED("coreStatusNormalAnimName")] 
		public CName CoreStatusNormalAnimName
		{
			get => GetProperty(ref _coreStatusNormalAnimName);
			set => SetProperty(ref _coreStatusNormalAnimName, value);
		}

		[Ordinal(13)] 
		[RED("coreStatusMalfunctionAnimName")] 
		public CName CoreStatusMalfunctionAnimName
		{
			get => GetProperty(ref _coreStatusMalfunctionAnimName);
			set => SetProperty(ref _coreStatusMalfunctionAnimName, value);
		}

		[Ordinal(14)] 
		[RED("coreStatusShutdownAnimName")] 
		public CName CoreStatusShutdownAnimName
		{
			get => GetProperty(ref _coreStatusShutdownAnimName);
			set => SetProperty(ref _coreStatusShutdownAnimName, value);
		}

		[Ordinal(15)] 
		[RED("coreStatusShutingDownAnimName")] 
		public CName CoreStatusShutingDownAnimName
		{
			get => GetProperty(ref _coreStatusShutingDownAnimName);
			set => SetProperty(ref _coreStatusShutingDownAnimName, value);
		}

		[Ordinal(16)] 
		[RED("failurePopupAnimName")] 
		public CName FailurePopupAnimName
		{
			get => GetProperty(ref _failurePopupAnimName);
			set => SetProperty(ref _failurePopupAnimName, value);
		}

		[Ordinal(17)] 
		[RED("successPopupAnimName")] 
		public CName SuccessPopupAnimName
		{
			get => GetProperty(ref _successPopupAnimName);
			set => SetProperty(ref _successPopupAnimName, value);
		}

		[Ordinal(18)] 
		[RED("stage")] 
		public CEnum<InnerBunkerCoreStage> Stage
		{
			get => GetProperty(ref _stage);
			set => SetProperty(ref _stage, value);
		}

		[Ordinal(19)] 
		[RED("sysIndex")] 
		public CInt32 SysIndex
		{
			get => GetProperty(ref _sysIndex);
			set => SetProperty(ref _sysIndex, value);
		}

		[Ordinal(20)] 
		[RED("systemsCheckAnimProxy")] 
		public CHandle<inkanimProxy> SystemsCheckAnimProxy
		{
			get => GetProperty(ref _systemsCheckAnimProxy);
			set => SetProperty(ref _systemsCheckAnimProxy, value);
		}

		[Ordinal(21)] 
		[RED("resultPopupAnimProxy")] 
		public CHandle<inkanimProxy> ResultPopupAnimProxy
		{
			get => GetProperty(ref _resultPopupAnimProxy);
			set => SetProperty(ref _resultPopupAnimProxy, value);
		}

		[Ordinal(22)] 
		[RED("coreStatusAnimProxy")] 
		public CHandle<inkanimProxy> CoreStatusAnimProxy
		{
			get => GetProperty(ref _coreStatusAnimProxy);
			set => SetProperty(ref _coreStatusAnimProxy, value);
		}

		public InnerBunkerCoreScreenGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
