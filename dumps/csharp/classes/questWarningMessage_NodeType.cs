using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questWarningMessage_NodeType : questIUIManagerNodeType
	{
		private CString _message;
		private LocalizationString _localizedMessage;
		private CFloat _duration;
		private CBool _show;
		private CBool _instant;
		private CEnum<gameSimpleMessageType> _type;

		[Ordinal(0)] 
		[RED("message")] 
		public CString Message
		{
			get => GetProperty(ref _message);
			set => SetProperty(ref _message, value);
		}

		[Ordinal(1)] 
		[RED("localizedMessage")] 
		public LocalizationString LocalizedMessage
		{
			get => GetProperty(ref _localizedMessage);
			set => SetProperty(ref _localizedMessage, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(3)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetProperty(ref _show);
			set => SetProperty(ref _show, value);
		}

		[Ordinal(4)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetProperty(ref _instant);
			set => SetProperty(ref _instant, value);
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<gameSimpleMessageType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public questWarningMessage_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
