using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardCollectedNotification : GenericNotificationController
	{
		private inkTextWidgetReference _shardTitle;
		private CHandle<redCallbackObject> _bbListenerId;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(16)] 
		[RED("shardTitle")] 
		public inkTextWidgetReference ShardTitle
		{
			get => GetProperty(ref _shardTitle);
			set => SetProperty(ref _shardTitle, value);
		}

		[Ordinal(17)] 
		[RED("bbListenerId")] 
		public CHandle<redCallbackObject> BbListenerId
		{
			get => GetProperty(ref _bbListenerId);
			set => SetProperty(ref _bbListenerId, value);
		}

		[Ordinal(18)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		public ShardCollectedNotification(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
