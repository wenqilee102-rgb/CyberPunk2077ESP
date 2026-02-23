using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseScriptableAction : gamedeviceAction
	{
		private entEntityID _requesterID;
		private wCHandle<gameObject> _executor;
		private wCHandle<gameObject> _proxyExecutor;
		private CArray<wCHandle<gamedataObjectActionCost_Record>> _costComponents;
		private TweakDBID _objectActionID;
		private wCHandle<gamedataObjectAction_Record> _objectActionRecord;
		private TweakDBID _inkWidgetID;
		private gameinteractionsChoice _interactionChoice;
		private CName _interactionLayer;
		private CBool _isActionRPGCheckDissabled;
		private CBool _canSkipPayCost;
		private CInt32 _calculatedBaseCost;
		private CHandle<DeviceActionQueue> _deviceActionQueue;
		private CBool _isActionQueueingUsed;
		private CBool _isQueuedAction;
		private CBool _isInactive;
		private CBool _isTargetDead;
		private CFloat _activationTimeReduction;
		private CBool _isAppliedByMonowire;

		[Ordinal(4)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get => GetProperty(ref _requesterID);
			set => SetProperty(ref _requesterID, value);
		}

		[Ordinal(5)] 
		[RED("executor")] 
		public wCHandle<gameObject> Executor
		{
			get => GetProperty(ref _executor);
			set => SetProperty(ref _executor, value);
		}

		[Ordinal(6)] 
		[RED("proxyExecutor")] 
		public wCHandle<gameObject> ProxyExecutor
		{
			get => GetProperty(ref _proxyExecutor);
			set => SetProperty(ref _proxyExecutor, value);
		}

		[Ordinal(7)] 
		[RED("costComponents")] 
		public CArray<wCHandle<gamedataObjectActionCost_Record>> CostComponents
		{
			get => GetProperty(ref _costComponents);
			set => SetProperty(ref _costComponents, value);
		}

		[Ordinal(8)] 
		[RED("objectActionID")] 
		public TweakDBID ObjectActionID
		{
			get => GetProperty(ref _objectActionID);
			set => SetProperty(ref _objectActionID, value);
		}

		[Ordinal(9)] 
		[RED("objectActionRecord")] 
		public wCHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get => GetProperty(ref _objectActionRecord);
			set => SetProperty(ref _objectActionRecord, value);
		}

		[Ordinal(10)] 
		[RED("inkWidgetID")] 
		public TweakDBID InkWidgetID
		{
			get => GetProperty(ref _inkWidgetID);
			set => SetProperty(ref _inkWidgetID, value);
		}

		[Ordinal(11)] 
		[RED("interactionChoice")] 
		public gameinteractionsChoice InteractionChoice
		{
			get => GetProperty(ref _interactionChoice);
			set => SetProperty(ref _interactionChoice, value);
		}

		[Ordinal(12)] 
		[RED("interactionLayer")] 
		public CName InteractionLayer
		{
			get => GetProperty(ref _interactionLayer);
			set => SetProperty(ref _interactionLayer, value);
		}

		[Ordinal(13)] 
		[RED("isActionRPGCheckDissabled")] 
		public CBool IsActionRPGCheckDissabled
		{
			get => GetProperty(ref _isActionRPGCheckDissabled);
			set => SetProperty(ref _isActionRPGCheckDissabled, value);
		}

		[Ordinal(14)] 
		[RED("canSkipPayCost")] 
		public CBool CanSkipPayCost
		{
			get => GetProperty(ref _canSkipPayCost);
			set => SetProperty(ref _canSkipPayCost, value);
		}

		[Ordinal(15)] 
		[RED("calculatedBaseCost")] 
		public CInt32 CalculatedBaseCost
		{
			get => GetProperty(ref _calculatedBaseCost);
			set => SetProperty(ref _calculatedBaseCost, value);
		}

		[Ordinal(16)] 
		[RED("deviceActionQueue")] 
		public CHandle<DeviceActionQueue> DeviceActionQueue
		{
			get => GetProperty(ref _deviceActionQueue);
			set => SetProperty(ref _deviceActionQueue, value);
		}

		[Ordinal(17)] 
		[RED("isActionQueueingUsed")] 
		public CBool IsActionQueueingUsed
		{
			get => GetProperty(ref _isActionQueueingUsed);
			set => SetProperty(ref _isActionQueueingUsed, value);
		}

		[Ordinal(18)] 
		[RED("isQueuedAction")] 
		public CBool IsQueuedAction
		{
			get => GetProperty(ref _isQueuedAction);
			set => SetProperty(ref _isQueuedAction, value);
		}

		[Ordinal(19)] 
		[RED("isInactive")] 
		public CBool IsInactive
		{
			get => GetProperty(ref _isInactive);
			set => SetProperty(ref _isInactive, value);
		}

		[Ordinal(20)] 
		[RED("isTargetDead")] 
		public CBool IsTargetDead
		{
			get => GetProperty(ref _isTargetDead);
			set => SetProperty(ref _isTargetDead, value);
		}

		[Ordinal(21)] 
		[RED("activationTimeReduction")] 
		public CFloat ActivationTimeReduction
		{
			get => GetProperty(ref _activationTimeReduction);
			set => SetProperty(ref _activationTimeReduction, value);
		}

		[Ordinal(22)] 
		[RED("IsAppliedByMonowire")] 
		public CBool IsAppliedByMonowire
		{
			get => GetProperty(ref _isAppliedByMonowire);
			set => SetProperty(ref _isAppliedByMonowire, value);
		}

		public BaseScriptableAction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
