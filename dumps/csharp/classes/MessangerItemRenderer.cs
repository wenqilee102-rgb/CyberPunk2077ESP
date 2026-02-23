using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessangerItemRenderer : JournalEntryListItemController
	{
		private inkImageWidgetReference _image;
		private inkWidgetReference _container;
		private inkImageWidgetReference _messageBubbleBG;
		private inkImageWidgetReference _messageBubbleFG;
		private inkImageWidgetReference _replyBubbleBG;
		private inkImageWidgetReference _replyBubbleFG;
		private CName _stateMessage;
		private CName _statePlayerReply;
		private CName _stateQuestReply;
		private TweakDBID _imageId;

		[Ordinal(19)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetProperty(ref _image);
			set => SetProperty(ref _image, value);
		}

		[Ordinal(20)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}

		[Ordinal(21)] 
		[RED("MessageBubbleBG")] 
		public inkImageWidgetReference MessageBubbleBG
		{
			get => GetProperty(ref _messageBubbleBG);
			set => SetProperty(ref _messageBubbleBG, value);
		}

		[Ordinal(22)] 
		[RED("MessageBubbleFG")] 
		public inkImageWidgetReference MessageBubbleFG
		{
			get => GetProperty(ref _messageBubbleFG);
			set => SetProperty(ref _messageBubbleFG, value);
		}

		[Ordinal(23)] 
		[RED("ReplyBubbleBG")] 
		public inkImageWidgetReference ReplyBubbleBG
		{
			get => GetProperty(ref _replyBubbleBG);
			set => SetProperty(ref _replyBubbleBG, value);
		}

		[Ordinal(24)] 
		[RED("ReplyBubbleFG")] 
		public inkImageWidgetReference ReplyBubbleFG
		{
			get => GetProperty(ref _replyBubbleFG);
			set => SetProperty(ref _replyBubbleFG, value);
		}

		[Ordinal(25)] 
		[RED("stateMessage")] 
		public CName StateMessage
		{
			get => GetProperty(ref _stateMessage);
			set => SetProperty(ref _stateMessage, value);
		}

		[Ordinal(26)] 
		[RED("statePlayerReply")] 
		public CName StatePlayerReply
		{
			get => GetProperty(ref _statePlayerReply);
			set => SetProperty(ref _statePlayerReply, value);
		}

		[Ordinal(27)] 
		[RED("stateQuestReply")] 
		public CName StateQuestReply
		{
			get => GetProperty(ref _stateQuestReply);
			set => SetProperty(ref _stateQuestReply, value);
		}

		[Ordinal(28)] 
		[RED("imageId")] 
		public TweakDBID ImageId
		{
			get => GetProperty(ref _imageId);
			set => SetProperty(ref _imageId, value);
		}

		public MessangerItemRenderer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
