using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneContactItemVirtualController : inkVirtualCompoundItemController
	{
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _preview;
		private inkTextWidgetReference _msgCount;
		private inkWidgetReference _msgIndicator;
		private inkWidgetReference _questFlag;
		private inkWidgetReference _regFlag;
		private inkWidgetReference _replyAlertIcon;
		private inkWidgetReference _callInputHint;
		private inkWidgetReference _chatInputHint;
		private inkWidgetReference _separtor;
		private CHandle<inkanimProxy> _animProxySelection;
		private CHandle<inkanimProxy> _animProxyHide;
		private CHandle<ContactData> _contactData;
		private CHandle<PulseAnimation> _pulse;
		private CBool _isQuestImportant;
		private CBool _isUnread;
		private CBool _isCallingEnabled;
		private wCHandle<inkWidget> _root;

		[Ordinal(18)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(19)] 
		[RED("preview")] 
		public inkTextWidgetReference Preview
		{
			get => GetProperty(ref _preview);
			set => SetProperty(ref _preview, value);
		}

		[Ordinal(20)] 
		[RED("msgCount")] 
		public inkTextWidgetReference MsgCount
		{
			get => GetProperty(ref _msgCount);
			set => SetProperty(ref _msgCount, value);
		}

		[Ordinal(21)] 
		[RED("msgIndicator")] 
		public inkWidgetReference MsgIndicator
		{
			get => GetProperty(ref _msgIndicator);
			set => SetProperty(ref _msgIndicator, value);
		}

		[Ordinal(22)] 
		[RED("questFlag")] 
		public inkWidgetReference QuestFlag
		{
			get => GetProperty(ref _questFlag);
			set => SetProperty(ref _questFlag, value);
		}

		[Ordinal(23)] 
		[RED("regFlag")] 
		public inkWidgetReference RegFlag
		{
			get => GetProperty(ref _regFlag);
			set => SetProperty(ref _regFlag, value);
		}

		[Ordinal(24)] 
		[RED("replyAlertIcon")] 
		public inkWidgetReference ReplyAlertIcon
		{
			get => GetProperty(ref _replyAlertIcon);
			set => SetProperty(ref _replyAlertIcon, value);
		}

		[Ordinal(25)] 
		[RED("callInputHint")] 
		public inkWidgetReference CallInputHint
		{
			get => GetProperty(ref _callInputHint);
			set => SetProperty(ref _callInputHint, value);
		}

		[Ordinal(26)] 
		[RED("chatInputHint")] 
		public inkWidgetReference ChatInputHint
		{
			get => GetProperty(ref _chatInputHint);
			set => SetProperty(ref _chatInputHint, value);
		}

		[Ordinal(27)] 
		[RED("separtor")] 
		public inkWidgetReference Separtor
		{
			get => GetProperty(ref _separtor);
			set => SetProperty(ref _separtor, value);
		}

		[Ordinal(28)] 
		[RED("animProxySelection")] 
		public CHandle<inkanimProxy> AnimProxySelection
		{
			get => GetProperty(ref _animProxySelection);
			set => SetProperty(ref _animProxySelection, value);
		}

		[Ordinal(29)] 
		[RED("animProxyHide")] 
		public CHandle<inkanimProxy> AnimProxyHide
		{
			get => GetProperty(ref _animProxyHide);
			set => SetProperty(ref _animProxyHide, value);
		}

		[Ordinal(30)] 
		[RED("contactData")] 
		public CHandle<ContactData> ContactData
		{
			get => GetProperty(ref _contactData);
			set => SetProperty(ref _contactData, value);
		}

		[Ordinal(31)] 
		[RED("pulse")] 
		public CHandle<PulseAnimation> Pulse
		{
			get => GetProperty(ref _pulse);
			set => SetProperty(ref _pulse, value);
		}

		[Ordinal(32)] 
		[RED("isQuestImportant")] 
		public CBool IsQuestImportant
		{
			get => GetProperty(ref _isQuestImportant);
			set => SetProperty(ref _isQuestImportant, value);
		}

		[Ordinal(33)] 
		[RED("isUnread")] 
		public CBool IsUnread
		{
			get => GetProperty(ref _isUnread);
			set => SetProperty(ref _isUnread, value);
		}

		[Ordinal(34)] 
		[RED("isCallingEnabled")] 
		public CBool IsCallingEnabled
		{
			get => GetProperty(ref _isCallingEnabled);
			set => SetProperty(ref _isCallingEnabled, value);
		}

		[Ordinal(35)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		public PhoneContactItemVirtualController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
