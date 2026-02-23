using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PoliceMessageGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _messageTextRef;
		private wCHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_NotificationsDef> _blackboardDef;
		private CHandle<redCallbackObject> _warningMessageCallbackId;
		private gameSimpleScreenMessage _simpleMessage;
		private wCHandle<inkWidget> _root;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(9)] 
		[RED("messageTextRef")] 
		public inkTextWidgetReference MessageTextRef
		{
			get => GetProperty(ref _messageTextRef);
			set => SetProperty(ref _messageTextRef, value);
		}

		[Ordinal(10)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(11)] 
		[RED("blackboardDef")] 
		public CHandle<UI_NotificationsDef> BlackboardDef
		{
			get => GetProperty(ref _blackboardDef);
			set => SetProperty(ref _blackboardDef, value);
		}

		[Ordinal(12)] 
		[RED("warningMessageCallbackId")] 
		public CHandle<redCallbackObject> WarningMessageCallbackId
		{
			get => GetProperty(ref _warningMessageCallbackId);
			set => SetProperty(ref _warningMessageCallbackId, value);
		}

		[Ordinal(13)] 
		[RED("simpleMessage")] 
		public gameSimpleScreenMessage SimpleMessage
		{
			get => GetProperty(ref _simpleMessage);
			set => SetProperty(ref _simpleMessage, value);
		}

		[Ordinal(14)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(15)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		public PoliceMessageGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
